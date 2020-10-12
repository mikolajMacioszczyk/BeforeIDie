import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DreamBlackquoteComponent } from './dream-blackquote.component';

describe('DreamBlackquoteComponent', () => {
  let component: DreamBlackquoteComponent;
  let fixture: ComponentFixture<DreamBlackquoteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DreamBlackquoteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DreamBlackquoteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
