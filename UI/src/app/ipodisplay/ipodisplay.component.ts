import { Component, OnInit } from '@angular/core';
import { IPOEntity } from '../ipoentity';
import { ProductService } from '../Shared/product.service';
import { Router} from '@angular/router'; 



@Component({
  selector: 'app-ipodisplay',
  templateUrl: './ipodisplay.component.html',
  styleUrls: ['./ipodisplay.component.css']
})
export class IpodisplayComponent implements OnInit {
  id : number;
  companyName : string;
  stockExchange : string;
  pricePerShare : number;
  totalNoOfShares : number;
  openDateTime : Date;
  remarks : string;
  objipo : IPOEntity;
  list : any;

  constructor(private service : ProductService, private router:Router) { 
    this.objipo = new IPOEntity();
  }

  ngOnInit() {
  }
  getallipo()
  {
    this.service.getallipo().subscribe(i=>{
      this.list = i;
      console.log(this.list);
    });
  }

}
