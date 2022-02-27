import { Component, OnInit } from '@angular/core';
import { NorthwindService } from '../core/northwind.service';
import { ProductDto } from '../models/productDto';

@Component({
  selector: 'app-products',
  templateUrl: './products.page.html',
  styleUrls: ['./products.page.scss'],
})
export class ProductsPage implements OnInit {
  products: ProductDto[] = [];
  entries = [{name: 'productId', isChecked: true}, 
             {name: 'productName', isChecked: true},
             {name: 'categoryName', isChecked: true},
             {name: 'companyName', isChecked: true},
             {name: 'price', isChecked: true},]
  showCard: boolean = false;
  showBtn: boolean = true;

  constructor(private northwindService: NorthwindService) { }

  ngOnInit() {
    this.northwindService.getProducts().subscribe(x => {
      console.log(x);
      this.products = x;
    });
  }

  setShowCard(): void{
    if(this.showCard == true){
      this.showCard = false;
      this.showBtn = true;
    }else if(this.showCard == false){
      this.showCard = true;
      this.showBtn = false;
    }
  }

}
