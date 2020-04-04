import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PracDdComponent } from './prac-dd.component';

describe('PracDdComponent', () => {
  let component: PracDdComponent;
  let fixture: ComponentFixture<PracDdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PracDdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PracDdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
