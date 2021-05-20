import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {
  readonly APIUrL ="https://localhost:44348/ "

  constructor(private http:HttpClient) { }

  //Metodos para ABM categorias
  getCatList():Observable<any[]>{
    return this.http.get<any>(this.APIUrL+'Category');
  }

  addCategory (val:any) {
    return this.http.post(this.APIUrL + 'Category/Insert',val);
  }

  updateCategory(val: any) {
    return this.http.put(this.APIUrL + 'Category/Insert',val);
  }

  deleteCategory (val:any) {
    return this.http.delete<any>(this.APIUrL + 'Category/'+val)
  }

  //Metodos para ABM productos

  getProdList(): Observable<any[]> {
    return this.http.get<any>(this.APIUrL + 'Product');
  }

  addProduct(val: any) {
    return this.http.post(this.APIUrL + 'Product/Insert', val);
  }

  updateProduct(val: any) {
    return this.http.put(this.APIUrL + 'Product/Insert', val);
  }

  deleteProduct(val: any) {
    return this.http.delete<any>(this.APIUrL + 'Product/' + val)
  }
}   
