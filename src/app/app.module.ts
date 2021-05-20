import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './products/products.component';
import { CategoriesComponent } from './categories/categories.component';
import { GetCatComponent } from './categories/get-cat/get-cat.component';
import { InsertUpdateCatComponent } from './categories/insert-update-cat/insert-update-cat.component';
import { GetProductsComponent } from './products/get-products/get-products.component';
import { InsertUpdateProdComponent } from './products/insert-update-prod/insert-update-prod.component';

import { ApiserviceService } from './apiservice.service'; 
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';




@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    CategoriesComponent,
    GetCatComponent,
    InsertUpdateCatComponent,
    GetProductsComponent,
    InsertUpdateProdComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule, 
    FormsModule, 
    ReactiveFormsModule
  ],
  providers: [ApiserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
