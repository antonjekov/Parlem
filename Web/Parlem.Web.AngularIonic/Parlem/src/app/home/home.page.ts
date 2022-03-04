import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage implements OnInit{

  form: FormGroup;
  products: any;
  client: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.form = new FormGroup({
      docNum: new FormControl(null, {
        updateOn: 'blur',
        validators: [Validators.required]
      }),
    });
  }

  onDocNum(){
    if (!this.form.valid) {
      return;
    }
    this.http
    .get(`https://localhost:44319/api/products?docNum=${this.form.value.docNum}`)
    .subscribe(x=>this.products=x);
    this.http
    .get(`https://localhost:44319/api/clients?docNum=${this.form.value.docNum}`)
    .subscribe(x=>this.client=x);
  }
}
