import {Component, OnDestroy, OnInit} from '@angular/core';
import {GoalsService} from "../goals.service";
import {ActivatedRoute, Router} from "@angular/router";
import {Goal, IGoal} from "../Models/IGoal";
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {Subscription} from "rxjs";

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit, OnDestroy {
  goal: IGoal = new Goal();
  subscription = new Subscription();
  form: FormGroup;

  constructor(private service: GoalsService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.loadGoal();
    this.createForm();
  }

  private loadGoal(): void {
    let id: number = +this.route.snapshot.paramMap.get('id');
    this.subscription.add(this.service.getById(id).subscribe(res =>
      {
        this.goal = res;
        console.log(this.goal);
      }, error => this.router.navigate(['notFound'])
    ))
  }

  private createForm(): void{
    this.form = new FormGroup({
      title: new FormControl('', [Validators.required, Validators.maxLength(100)]),
      localization: new FormControl('', [Validators.required, Validators.maxLength(100)]),
      imageUrl: new FormControl('', Validators.required),
      description: new FormControl('', Validators.required),
    })
  }

  get title(){
    return this.form.get('title');
  }

  get localization(){
    return this.form.get('localization');
  }

  get imageUrl(){
    return this.form.get('imageUrl');
  }

  get description(){
    return this.form.get('description');
  }

  onSubmit() {
    this.subscription.add(this.service.update(this.goal.id, this.goal).subscribe(
      res => this.backHome(),
      error => console.log(error)
    ));
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  discard() {
    this.backHome()
  }

  private backHome(): void{
    this.router.navigate(['/']);
  }
}
