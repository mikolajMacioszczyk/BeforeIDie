import {Component, OnDestroy, OnInit} from '@angular/core';
import {GoalsRealizedService} from "../Services/goals-realized.service";
import {ActivatedRoute, Router} from "@angular/router";
import {Goal, IGoal} from "../Models/IGoal";
import {Subscription} from "rxjs";
import {FormControl, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: 'app-update-realized',
  templateUrl: './update-realized.component.html',
  styleUrls: ['./update-realized.component.css']
})
export class UpdateRealizedComponent implements OnInit, OnDestroy {
  goal: IGoal = new Goal();
  subscription = new Subscription();
  form: FormGroup;
  fullStar: number[];
  emptyStar: number[];
  maxRating = 6;

  constructor(private service: GoalsRealizedService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.loadGoal();
    this.createForm();
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  private loadGoal(): void {
    let id: number = +this.route.snapshot.paramMap.get('id');
    this.subscription.add(this.service.getById(id).subscribe(res =>
      {
        this.goal = res;
        this.arrangeArrays();
      }, error => this.router.navigate(['notFound'])
    ))
  }

  private createForm(): void{
    this.form = new FormGroup({
      title: new FormControl('', [Validators.required, Validators.maxLength(100)]),
      localization: new FormControl('', [Validators.required, Validators.maxLength(100)]),
      imageUrl: new FormControl('', Validators.required),
      description: new FormControl('', Validators.required),
      rating: new FormControl('', [Validators.required, Validators.min(1), Validators.max(6)]),
      feelings: new FormControl('', [Validators.required, Validators.maxLength(300)]),
      dateOfRealization: new FormControl('', Validators.required)
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

  get rating(){
    return this.form.get('rating');
  }

  get feelings(){
    return this.form.get('feelings');
  }

  get dateOfRealization(){
    return this.form.get('dateOfRealization');
  }

  onSubmit() {
    this.subscription.add(this.service.update(this.goal.id, this.goal).subscribe(
      res => this.backHome(),
      error => console.log(error)
    ));
  }

  private backHome(): void{
    this.router.navigate(['/realized']);
  }

  discard() {
    this.backHome();
  }

  arrangeArrays() {
    this.fullStar = new Array(Math.min(this.goal.rating, this.maxRating));
    this.emptyStar = new Array(this.maxRating - this.goal.rating);
  }
}
