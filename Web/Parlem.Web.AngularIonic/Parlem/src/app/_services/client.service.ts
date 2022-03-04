import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { Client } from '../_interfaces/client';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private http: HttpClient) { }

  getClientByDocNum(docNum: string){
    return this.http
    .get(`https://localhost:44319/api/clients?docNum=${docNum}`)
    .pipe(map(data=>data as Client));
  }
}
