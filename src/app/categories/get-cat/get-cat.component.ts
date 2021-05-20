import { Component, OnInit } from '@angular/core';

import {ApiserviceService} from 'src/app/apiservice.service';

@Component({
  selector: 'app-get-cat',
  templateUrl: './get-cat.component.html',
  styleUrls: ['./get-cat.component.css']
})
export class GetCatComponent implements OnInit {

  constructor(private service:ApiserviceService) { }

  CategoriesList:any=[]

  InsertarNuevaCategoria:string;
  ActivateInsertUpdateCatComp:boolean=false;
  cat:any;

  ngOnInit(): void {
    this.refreshCatList();

  }

  addClick(){
    this.cat={
      CategoryId:0,
      CategoryName:""
    }
    this.InsertarNuevaCategoria="Insert Category";
    this.ActivateInsertUpdateCatComp=true;
  }

  closeClick(){
    this.ActivateInsertUpdateCatComp=false;
    this.refreshCatList();
  }

  refreshCatList(){
    this.service.getCatList().subscribe(data=>{
      this.CategoriesList=data;
    });
  }

}
