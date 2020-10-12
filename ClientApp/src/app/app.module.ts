import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import {MatDialogModule} from '@angular/material/dialog';
import {MatButtonModule} from "@angular/material/button";
import {MatIconModule} from '@angular/material/icon';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import {MatNativeDateModule} from "@angular/material/core";
import {MatMenuModule} from '@angular/material/menu';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { NotFoundComponent } from './not-found/not-found.component';
import {GoalsPlannedService} from "./Services/goals.service";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { OneGoalComponent } from './one-goal/one-goal.component';
import { CreateComponent } from './create/create.component';
import { UpdateComponent } from './update/update.component';
import {GoalsRealizedService} from "./Services/goals-realized.service";
import { GoalsPlannedComponent } from './goals-planned/goals-planned.component';
import { GoalsRealizedComponent } from './goals-realized/goals-realized.component';
import { DreamBlackquoteComponent } from './dream-blackquote/dream-blackquote.component';
import { UpdateRealizedComponent } from './update-realized/update-realized.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    GoalsPlannedComponent,
    NotFoundComponent,
    OneGoalComponent,
    CreateComponent,
    UpdateComponent,
    GoalsPlannedComponent,
    GoalsRealizedComponent,
    DreamBlackquoteComponent,
    UpdateRealizedComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {path: '', component: GoalsPlannedComponent},
      {path: 'planned', component: GoalsPlannedComponent},
      {path: 'realized', component: GoalsRealizedComponent},
      {path: 'new', component: CreateComponent},
      {path: 'update/:id', component: UpdateComponent},
      {path: 'rUpdate/:id', component: UpdateRealizedComponent},
      {path: '**', component: NotFoundComponent}
    ]),
    BrowserAnimationsModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatNativeDateModule,
    MatButtonModule,
    MatDialogModule,
    MatIconModule,
    MatDatepickerModule,
    MatMenuModule
  ],
  providers: [GoalsPlannedService,
  GoalsRealizedService],
  entryComponents: [
    OneGoalComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
