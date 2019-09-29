import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class WinnerService {

  url = "https://dronesservices.azurewebsites.net/api/";

  constructor(private http: HttpClient) { }

  getPlayers() {
    return this.http.get(`${this.url}winner`);
  }
}
