import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VtbCalculatorComponent } from './vtb-calculator.component';

describe('VtbCalculatorComponentComponent', () => {
  let component: VtbCalculatorComponent;
  let fixture: ComponentFixture<VtbCalculatorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VtbCalculatorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VtbCalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
