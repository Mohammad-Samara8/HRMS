import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DepartmentsService {

  constructor(private _http: HttpClient) { }

  apiUrl: string = "https://localhost:44377/api/Departments";

  getDepartmentsList() {
    return this._http.get(this.apiUrl + "/GetDepartmentsList");
  }
}
