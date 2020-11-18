import { Injectable } from '@angular/core';
import { from } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../user';
import { Companyentity } from '../companyentity';
import { Exchange } from '../exchange';
import { IPOEntity } from '../ipoentity'
import { IpodisplayComponent } from '../ipodisplay/ipodisplay.component';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  username:string;
  usertype:string;

  constructor(private http : HttpClient) { }

  public Getallusers():Observable<User[]>
  {
    return this.http.get<User[]>("http://localhost:55665/api/User/getall");
  }

  public userLogin(user:User)
    {
      return this.http.post("http://localhost:55665/api/User/check",user,{ responseType: 'text' });
    }

    public adminLogin(user:User)
    {
      return this.http.post("http://localhost:55665/api/Admin/check",user,{ responseType: 'text' });
    }

    public add(user:User)
    {
      return this.http.post("http://localhost:55665/api/Admin/add",user,{ responseType: 'text' });
    }

    public addcompany(comp:Companyentity)
    {
      return this.http.post("http://localhost:54471/api/Company/addcompany",comp,{ responseType: 'text' });
    }

    public updatecompany(comp:Companyentity)
    {
      return this.http.put("http://localhost:54471/api/Company/updatecompany",comp,{ responseType: 'text' });
    }

    public addexchange(exch:Exchange)
    {
      return this.http.post("http://localhost:56874/api/StockExchange/add",exch,{ responseType: 'text' });
    }

    public getallexchange()
    {
      return this.http.get<Exchange[]>("http://localhost:56874/api/StockExchange/getall");
    }

    public addipo(objipo:IPOEntity)
    {
      return this.http.post("http://localhost:54471/api/Company/addIPO",objipo,{ responseType: 'text' });
    }

    public getallipo()
    {
      return this.http.get<IPOEntity[]>("http://localhost:54471/api/Company/getallipo");
    }
    
    public getstockpricelist(code:number,fromdate:Date,todate:Date,fromtime:string,totime:string):Observable<number[]>

    {​​

      return this.http.get<number[]>("http://localhost:54471/api/Company/getCompanyPriceList/"+code+"/"+fromdate+"/"+todate+"/"+fromtime+"/"+totime);

    }​​

    public getsectorstockpricelist(code:string,fromdate:Date,todate:Date,fromtime:string,totime:string):Observable<number[]>

    {​​

      return this.http.get<number[]>("http://localhost:62354/api/Sector/sectorpricelist/"+code+"/"+fromdate+"/"+todate+"/"+fromtime+"/"+totime);

    }​​


}
