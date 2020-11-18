import { Component, OnInit } from '@angular/core';
import { Companyentity } from '../companyentity'
import { ProductService } from '../Shared/product.service';
import { Router} from '@angular/router'; 

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})


export class CompanyComponent implements OnInit 
{
  companyId  : number;
  companyName :string;
  turnover : number;
  ceo : string;
  boardOfDirectors : string;
  listedinStockExchange : number;
  sector : string;
  briefWriteup : string;
  companyStockCode : number;
  comp : Companyentity;

  constructor(private service : ProductService, private router:Router) { 
    this.comp = new Companyentity();

  }

  ngOnInit() {
  }

  addcompany(){
    this.comp.companyId = this.companyId;
    this.comp.companyName = this.companyName;
    this.comp.turnover = this.turnover;
    this.comp.ceo = this.ceo;
    this.comp.boardOfDirectors = this.boardOfDirectors;
    this.comp.listedinStockExchange = this.listedinStockExchange;
    this.comp.sector = this.sector;
    this.comp.briefWriteup = this.briefWriteup
    this.comp.companyStockCode = this.companyStockCode;
    console.log(this.comp);
    this.service.addcompany(this.comp).subscribe(i=>{
      console.log(i.toString());
    });
    
 }
  updatecompany(){
    this.comp.companyId = this.companyId;
    this.comp.companyName = this.companyName;
    this.comp.turnover = this.turnover;
    this.comp.ceo = this.ceo;
    this.comp.boardOfDirectors = this.boardOfDirectors;
    this.comp.listedinStockExchange = this.listedinStockExchange;
    this.comp.sector = this.sector;
    this.comp.briefWriteup = this.briefWriteup
    this.comp.companyStockCode = this.companyStockCode;
    console.log(this.comp);
    this.service.updatecompany(this.comp).subscribe(i=>{
      console.log(i.toString());
    });
 }
}


  

