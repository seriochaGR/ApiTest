import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class GetPortsService {

  uri = 'http://localhost:51793/api/airportInformation/GetAllAirports';

  constructor(private http: HttpClient) { }

   
  getPorts() {
    return this
      .http
      .get(`${this.uri}`);
  }
}
