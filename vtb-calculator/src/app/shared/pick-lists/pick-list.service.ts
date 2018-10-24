import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';

import { PickListModel } from "src/app/shared/pick-lists/pick-list.model"

@Injectable({
  providedIn: 'root'
})
export class PickListService {

  constructor(private http: HttpClient) { }

  getOperationTypes() : Observable<PickListModel[]>{
    return this.http.get<PickListModel[]>("/api/picklists").pipe();
  }
}
