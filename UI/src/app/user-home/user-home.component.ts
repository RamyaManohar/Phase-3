import { Component, OnInit } from '@angular/core';
import { ProductService } from '../Shared/product.service';

@Component({
  selector: 'app-user-home',
  templateUrl: './user-home.component.html',
  styleUrls: ['./user-home.component.css']
})
export class UserHomeComponent implements OnInit {
   
  username:string;
  usertype:string;
  
  constructor(private service:ProductService) { 
    this.username = this.service.username;
    this.usertype = this.service.usertype;
  }

  ngOnInit() {
  }

}
