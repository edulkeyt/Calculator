import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

import { CalculationModel } from 'src/app/calculation/models/calculation-model'
import { CalculationResultModel } from 'src/app/calculation/models/calculation-result-model'

import { CalculateApiService } from 'src/app/calculation/services/calculate-api.service'

import { PickListService } from 'src/app/shared/pick-lists/pick-list.service'
import { PickListModel } from 'src/app/shared/pick-lists/pick-list.model'

@Component({
  selector: 'vtb-calculator',
  templateUrl: './vtb-calculator.component.html',
  styleUrls: ['./vtb-calculator.component.css']
})
export class VtbCalculatorComponent implements OnInit {

  @ViewChild('calculationForm') formRef: NgForm;

  public options: PickListModel[]

  public model: CalculationModel = new CalculationModel();

  public showErrors = false;

  public calculationResult = '';

  constructor(private calculateApiService: CalculateApiService,
    private pickListService: PickListService) { }

  ngOnInit() {
    this.pickListService.getOperationTypes().subscribe(
      result => {
        this.options = result;
      }
    );    
  }

  public onOperationSelected() {
  }

  public onCalculatePressed() {
    this.showErrors = true;

    if (this.formRef.valid) {
      this.calculateApiService.sendCalculationRequest(this.model).subscribe((result : CalculationResultModel) =>{
        if(!result.IsSuccessfull){
          this.calculationResult = result.Message;
        } else {
          this.calculationResult = result.Result.toString();
        }
      },
      error => {
        console.log(error);
      });
    }
  }
}
