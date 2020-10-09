import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OneGoalComponent } from './one-goal.component';

describe('OneGoalComponent', () => {
  let component: OneGoalComponent;
  let fixture: ComponentFixture<OneGoalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OneGoalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OneGoalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
