import { Component, OnInit } from '@angular/core';
import { NorthwindService } from '../core/northwind.service';
import { CustomerDto } from '../models/customerDto';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.page.html',
  styleUrls: ['./customers.page.scss'],
})
export class CustomersPage implements OnInit {
  customers: CustomerDto[] = [];


  constructor(private northwindService: NorthwindService) { }

  ngOnInit() {
    this.northwindService.getCustomers().subscribe(x => {
      this.customers = x;
    });
  }

}
