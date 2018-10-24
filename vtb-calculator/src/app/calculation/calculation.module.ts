import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { CalculateApiService } from 'src/app/calculation/services/calculate-api.service'

import { VtbCalculatorComponent } from 'src/app/calculation/components/vtb-calculator/vtb-calculator.component'

import { NgSelectModule } from '@ng-select/ng-select';
import { CalculationRoutingModule } from './/calculation-routing.module';

import { PickListService } from 'src/app/shared/pick-lists/pick-list.service'

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    NgSelectModule,
    CalculationRoutingModule
  ],
  declarations: [
    VtbCalculatorComponent
  ],
  providers: [
    CalculateApiService,
    PickListService
  ]
})
export class CalculationModule { }
