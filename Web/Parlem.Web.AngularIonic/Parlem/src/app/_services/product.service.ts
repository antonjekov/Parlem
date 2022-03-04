import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { Product } from '../_interfaces/product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }
  getProductsByDocNum(docNum: string){
    return this.http
    .get(`https://localhost:44319/api/products?docNum=${docNum}`)
    .pipe(map(data=>data as Product[]));
  }
}
