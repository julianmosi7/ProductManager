import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { NorthwindService } from '../core/northwind.service';
import { CustomerDto } from '../models/customerDto';
import { ProductDto } from '../models/productDto';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {  

  constructor() {}

  ngOnInit(){
    
  }
}
