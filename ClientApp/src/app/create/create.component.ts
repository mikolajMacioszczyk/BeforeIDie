import {Component, OnDestroy, OnInit} from '@angular/core';
import {Goal, IGoal} from "../Models/IGoal";
import {GoalsService} from "../goals.service";
import {Router} from "@angular/router";
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {Subscription} from "rxjs";

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit, OnDestroy {
  form: FormGroup;
  goal = new Goal();
  subscription: Subscription;

  constructor(private service: GoalsService, private router: Router) { }

  ngOnInit() {
    this.form = new FormGroup({
      title: new FormControl('', [Validators.required, Validators.maxLength(100)]),
      localization: new FormControl('', [Validators.required, Validators.maxLength(100)]),
      imageUrl: new FormControl('', Validators.required),
      description: new FormControl('', Validators.required)
    });
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
    this.subscription = this.service.create(this.goal).subscribe(res => {
      this.router.navigate(['/']);
    });
  }

  ngOnDestroy(): void {
    if (this.subscription){
      this.subscription.unsubscribe();
    }
  }
}
