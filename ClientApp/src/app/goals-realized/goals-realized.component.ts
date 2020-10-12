import {Component, OnDestroy, OnInit} from '@angular/core';
import {GoalsRealizedService} from "../Services/goals-realized.service";
import {IGoal} from "../Models/IGoal";
import {Subscription} from "rxjs";
import {OneGoalComponent} from "../one-goal/one-goal.component";
import {MatDialog} from "@angular/material/dialog";
import {Router} from "@angular/router";

@Component({
  selector: 'app-goals-realized',
  templateUrl: './goals-realized.component.html',
  styleUrls: ['./goals-realized.component.css']
})
export class GoalsRealizedComponent implements OnInit, OnDestroy {
  goals: IGoal[];
  subscription = new Subscription();

  constructor(private service: GoalsRealizedService, public dialog: MatDialog, private router: Router) { }

  ngOnInit() {
    this.subscription.add(this.service.getAll().subscribe(res => {
      this.goals = res;
    }));
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  openDialog(id: number) {
    this.subscription.add(this.service.getById(id).subscribe((res: IGoal)  => {
      const dialogRef = this.dialog.open(OneGoalComponent, {data: {source: res}});
      dialogRef.afterClosed().subscribe(res => {
        if (res == 'Delete' && confirm("Czy na pewno chcesz usunąć?") ){
          this.deleteById(id);
        }
        else if (res == "Edit"){
          this.router.navigate(['update/', id]);
        }
      })
    }));
  }

  private deleteById(id: number){
    let idx: number = this.goals.findIndex(g => g.id == id);
    let item: IGoal = this.goals[idx];
    this.goals.splice(idx, 1);
    this.service.delete(id).subscribe(res => {},
      error => {
        this.goals.splice(idx, 0, item);
      });
  }
}
