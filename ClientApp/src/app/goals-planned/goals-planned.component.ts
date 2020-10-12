import {Component, OnDestroy, OnInit} from '@angular/core';
import {IGoal} from "../Models/IGoal";
import {Subscription} from "rxjs";
import {GoalsPlannedService} from "../Services/goals.service";
import {MatDialog} from "@angular/material/dialog";
import {Router} from "@angular/router";
import {OneGoalComponent} from "../one-goal/one-goal.component";

@Component({
  selector: 'app-goals-planned',
  templateUrl: './goals-planned.component.html',
  styleUrls: ['./goals-planned.component.css']
})
export class GoalsPlannedComponent implements OnInit, OnDestroy {
  goals: IGoal[];
  subscription = new Subscription();

  constructor(private service: GoalsPlannedService, public dialog: MatDialog, private router: Router) { }

  ngOnInit() {
    this.subscription.add(this.service.getAll().subscribe(res => {
      this.goals = res;
    }, error => console.log(error) ));
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

  openDialog(id: number) {
    this.subscription.add(this.service.getById(id).subscribe((res: IGoal)  => {
      this.dialog.open(OneGoalComponent, {data: {source: res}});
    }));
  }

  deleteById(id: number){
    if (!confirm("Czy na pewno chcesz usunąc?")){return;}
    let idx: number = this.goals.findIndex(g => g.id == id);
    let item: IGoal = this.goals[idx];
    this.goals.splice(idx, 1);
    this.service.delete(id).subscribe(res => {},
      error => {
        this.goals.splice(idx, 0, item);
      });
  }

  edit(id: number) {
    this.router.navigate(['update', id]);
  }

  updateStatus(id: number) {
    let goal: IGoal = this.goals.find(g => g.id == id);
    let idx = this.goals.indexOf(goal);
    if (idx >= 0){
      this.goals.splice(idx, 1);
      this.subscription.add(this.service.updateStatus(id, 1)
        .subscribe(res => {},
          error => {
          console.log(error);
          this.goals.splice(idx, 0, goal);
          }));
    }
  }
}
