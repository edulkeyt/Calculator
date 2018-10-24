import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';

import { CalculationResultModel } from 'src/app/calculation/models/calculation-result-model'
import { CalculationModel } from 'src/app/calculation/models/calculation-model' 

@Injectable({
  providedIn: 'root'
})
export class CalculateApiService {

  constructor(private http: HttpClient) { }

  public sendCalculationRequest(model: CalculationModel) : Observable<CalculationResultModel> {
    return this.http.post<CalculationResultModel>('/api/Calculation', CalculateApiService.toCalculationTransportModel(model))
  }

  static toCalculationTransportModel(model: CalculationModel){
    return {
      LeftOperand: model.leftOperand,
      RightOperand: model.rightOperand,
      OperationType: model.operation
    }
  }
}
