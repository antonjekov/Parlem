import { HttpClient } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { Client } from './client';
import { Product } from './product';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage implements OnInit, OnDestroy{

  form: FormGroup;
  products: Product[];
  client: Client;
  prodSub: Subscription;
  clientSub: Subscription;

  constructor(private http: HttpClient) {}


  ngOnInit(): void {
    this.form = new FormGroup({
      docNum: new FormControl(null, {
        updateOn: 'blur',
        validators: [Validators.required]
      }),
    });
  }

  ngOnDestroy(): void {
    this.clientSub.unsubscribe();
    this.prodSub.unsubscribe();
  }

  onDocNum(){
    if (!this.form.valid) {
      return;
    }

    this.prodSub = this.http
    .get(`https://localhost:44319/api/products?docNum=${this.form.value.docNum}`)
    .subscribe(x=>this.products=x as Product[]);

    this.clientSub = this.http
    .get(`https://localhost:44319/api/clients?docNum=${this.form.value.docNum}`)
    .subscribe(x=>this.client=x as Client);
  }
}
