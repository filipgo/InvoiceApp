import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class InvoiceService {
  private headers: HttpHeaders;
  private accessPointUrl = 'https://localhost:5001/api/invoice';

  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
   }

   public getAll() {
     return this.http.get(this.accessPointUrl, {headers: this.headers});
   }

   public get(id) {
    return this.http.get(this.accessPointUrl + '/' + id, {headers: this.headers});
   }

   public add(payload) {
    return this.http.post(this.accessPointUrl, payload, {headers: this.headers});
   }

   public update(payload) {
    return this.http.delete(this.accessPointUrl + '/' + payload.id, {headers: this.headers});
   }

   public remove(payload) {
    return this.http.put(this.accessPointUrl + '/' + payload.id, {headers: this.headers});
   }
}
