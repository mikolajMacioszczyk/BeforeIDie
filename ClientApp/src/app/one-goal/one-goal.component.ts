import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA} from "@angular/material/dialog";
import {IGoal} from "../Models/IGoal";

@Component({
  selector: 'app-one-goal',
  templateUrl: './one-goal.component.html',
  styleUrls: ['./one-goal.component.css']
})
export class OneGoalComponent implements OnInit {
  goal: IGoal;
  fullStars: number[];
  emptyStars: number[];
  private maxRating = 6;

  constructor(@Inject(MAT_DIALOG_DATA) public data: any) {
    this.goal = data.source;
    if (this.goal.rating){
      this.fullStars = Array(this.goal.rating);
      this.emptyStars = Array(this.maxRating - this.goal.rating);
    }
  }

  ngOnInit() {
  }

}
