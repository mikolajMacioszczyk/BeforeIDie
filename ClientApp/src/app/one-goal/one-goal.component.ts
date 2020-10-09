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

  constructor(@Inject(MAT_DIALOG_DATA) public data: any) {
    this.goal = data.source;
  }

  ngOnInit() {
  }

}
