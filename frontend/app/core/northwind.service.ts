import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CustomerDto } from '../models/customerDto';
import { ProductDto } from '../models/productDto';

@Injectable({
  providedIn: 'root'
})
export class NorthwindService {

  constructor(private httpClient: HttpClient ) { }

  url="http://localhost:5000/Northwind";

  getCustomers(): Observable<CustomerDto[]>{
    return this.httpClient.get<CustomerDto[]>(`${this.url}/GetCustomers`);
  }

  getProducts(): Observable<ProductDto[]>{
    return this.httpClient.get<ProductDto[]>(`${this.url}/GetProducts`);
  }

}
