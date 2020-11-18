import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { AdminHomeComponent} from './admin-home/admin-home.component';
import { UserHomeComponent} from './user-home/user-home.component';
import { SignupComponent } from './signup/signup.component';
import { CompanyComponent } from './company/company.component';
import { ExchangeComponent } from './exchange/exchange.component';
import { IPOComponent } from './ipo/ipo.component';
import { IpodisplayComponent } from './ipodisplay/ipodisplay.component';
import { ChartsComponent } from './charts/charts.component';
import { SectorchartComponent } from './sectorchart/sectorchart.component';

const routes: Routes = [
  {path:'Login',component:LoginComponent},
  {path:'adminhome',component:AdminHomeComponent},
  {path:'userhome',component:UserHomeComponent},
  {path:'signup',component:SignupComponent},
  {path:'company',component:CompanyComponent},
  {path:'exchange',component:ExchangeComponent},
  {path: 'ipo', component:IPOComponent},
  {path: 'ipodisplay', component:IpodisplayComponent},
  {path:'charts',component:ChartsComponent},
  {path:'sectorchart',component:SectorchartComponent},
  {path:'',redirectTo: 'Login',pathMatch:"full"}
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
