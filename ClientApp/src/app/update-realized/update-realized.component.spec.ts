import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateRealizedComponent } from './update-realized.component';

describe('UpdateRealizedComponent', () => {
  let component: UpdateRealizedComponent;
  let fixture: ComponentFixture<UpdateRealizedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdateRealizedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateRealizedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
