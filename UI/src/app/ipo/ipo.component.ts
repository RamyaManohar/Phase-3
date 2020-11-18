import { Component, OnInit } from '@angular/core';
import { IPOEntity } from '../ipoentity';
import { ProductService } from '../Shared/product.service';
import { Router} from '@angular/router'; 

@Component({
  selector: 'app-ipo',
  templateUrl: './ipo.component.html',
  styleUrls: ['./ipo.component.css']
})
export class IPOComponent implements OnInit {
  id : number;
  companyName : string;
  stockExchange : string;
  pricePerShare : number;
  totalNoOfShares : number;
  openDateTime : Date;
  remarks : string;
  objipo : IPOEntity;

  constructor(private service : ProductService, private router:Router) { 
    this.objipo = new IPOEntity();

  }

  ngOnInit() {
  }

  AddIPO()
  {
    this.objipo.id = this.id;
    this.objipo.companyName = this.companyName;
    this.objipo.stockExchange = this.stockExchange;
    this.objipo.pricePerShare = this.pricePerShare;
    this.objipo.totalNoOfShares = this.totalNoOfShares;
    this.objipo.openDateTime = this.openDateTime;
    this.objipo.remarks = this.remarks;
    
    console.log(this.objipo);
    this.service.addipo(this.objipo).subscribe(i=>{
      console.log(i.toString());
    });
  }

}
