import { Component, OnInit } from '@angular/core';

import {ApiserviceService} from 'src/app/apiservice.service';

@Component({
  selector: 'app-get-products',
  templateUrl: './get-products.component.html',
  styleUrls: ['./get-products.component.css']
})
export class GetProductsComponent implements OnInit {

  constructor(private service:ApiserviceService) { }

  ProductsList:any=[];

  InsertarNuevoProducto: string;
  ActivateInsertUpdateProdComp: boolean = false;
  prod: any;

  ngOnInit(): void {
    this.service.getProdList()
  }

  addClick() {
    this.prod = {
      ProductId: 0,
      ProductName: ""
    }
    this.InsertarNuevoProducto = "Insert Product";
    this.ActivateInsertUpdateProdComp = true;
  }

  closeClick() {
    this.ActivateInsertUpdateProdComp = false;
    this.refreshProdList();
  }


  refreshProdList(){
    this.service.getProdList().subscribe(data=>{
      this.ProductsList=data;
    });
  }
}
