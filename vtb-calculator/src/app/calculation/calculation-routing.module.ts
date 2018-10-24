import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { VtbCalculatorComponent } from 'src/app/calculation/components/vtb-calculator/vtb-calculator.component'

const routes: Routes = [
  {
    path: 'calculation',
    component: VtbCalculatorComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule],
})
export class CalculationRoutingModule { }
