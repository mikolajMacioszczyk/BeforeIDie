import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GoalsRealizedComponent } from './goals-realized.component';

describe('GoalsRealizedComponent', () => {
  let component: GoalsRealizedComponent;
  let fixture: ComponentFixture<GoalsRealizedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GoalsRealizedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GoalsRealizedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
