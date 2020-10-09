import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import {MatDialogModule} from '@angular/material/dialog';
import {MatButtonModule} from "@angular/material/button";

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { GoalsComponent } from './goals/goals.component';
import { NotFoundComponent } from './not-found/not-found.component';
import {GoalsService} from "./goals.service";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { OneGoalComponent } from './one-goal/one-goal.component';
import { CreateComponent } from './create/create.component';
import { UpdateComponent } from './update/update.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    GoalsComponent,
    NotFoundComponent,
    OneGoalComponent,
    CreateComponent,
    UpdateComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    MatButtonModule,
    MatDialogModule,
    RouterModule.forRoot([
      {path: '', component: GoalsComponent},
      {path: 'goals', component: GoalsComponent},
      {path: 'new', component: CreateComponent},
      {path: 'update/:id', component: UpdateComponent},
      {path: '**', component: NotFoundComponent}
    ]),
    BrowserAnimationsModule,
    ReactiveFormsModule,
  ],
  providers: [GoalsService],
  entryComponents: [
    OneGoalComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
