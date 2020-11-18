import { Component, OnInit } from '@angular/core';
import { ProductService } from '../Shared/product.service';
import { Router} from '@angular/router'; 
import { Exchange } from '../exchange';


@Component({
  selector: 'app-exchange',
  templateUrl: './exchange.component.html',
  styleUrls: ['./exchange.component.css']
})
export class ExchangeComponent implements OnInit {
  list: any;
  seid: number;
  stockExchange: string;
  brief: string;
  address: string;
  remarks: string;
  exch: Exchange;
  constructor(private service : ProductService, private router:Router) {
    this.exch = new Exchange();

   }

  ngOnInit() {
  }

  addexchange(){
    this.exch.seid = this.seid;
    this.exch.stockExchange = this.stockExchange;
    this.exch.brief = this.brief;
    this.exch.address = this.address;
    this.exch.remarks = this.remarks;
    
    console.log(this.exch);
    this.service.addexchange(this.exch).subscribe(i=>{
      console.log(i.toString());
    });

  }

  getexchange()
  {
    this.service.getallexchange().subscribe(i=>{
      this.list = i;
      console.log(this.list);
    });

  }

}
