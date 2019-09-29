import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class PlayerService {

  url = "https://dronesservices.azurewebsites.net/api/";

  constructor(private http: HttpClient) { }

  getPlayers() {
    const headers = new HttpHeaders({
      'Content-type': 'application/json; charset=utf-8'
    })

    return this.http.get(`${this.url}player`);
  }
}