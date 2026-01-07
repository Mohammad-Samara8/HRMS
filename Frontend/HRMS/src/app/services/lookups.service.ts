import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LookupsService {

  constructor(private _http: HttpClient) { }

  apiUrl: string = "https://localhost:44377/api/Lookups";

  getByMajorCode(majorCode: number) {
    let params = new HttpParams();
    params = params.set("MajorCode", majorCode);

    return this._http.get(this.apiUrl + "/GetByMajorCode", { params });
  }
}
