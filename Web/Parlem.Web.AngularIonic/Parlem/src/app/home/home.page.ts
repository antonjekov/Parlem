import { HttpClient } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { Client } from '../_interfaces/client';
import { Product } from '../_interfaces/product';
import { ClientService } from '../_services/client.service';
import { ProductService } from '../_services/product.service';

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

  constructor(
    private http: HttpClient,
    private clientService: ClientService,
    private productsService: ProductService) {}


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

    const docNum = this.form.value.docNum;
    this.prodSub = this.productsService.getProductsByDocNum(docNum).subscribe(x=>this.products=x);
    this.clientSub = this.clientService.getClientByDocNum(docNum).subscribe(x=>this.client=x);
  }
}
