import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GoalsPlannedComponent } from './goals-planned.component';

describe('GoalsPlannedComponent', () => {
  let component: GoalsPlannedComponent;
  let fixture: ComponentFixture<GoalsPlannedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GoalsPlannedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GoalsPlannedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
