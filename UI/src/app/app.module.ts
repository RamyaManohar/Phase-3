import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule} from "@angular/common/http";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { UserHomeComponent } from './user-home/user-home.component';
import { SignupComponent } from './signup/signup.component';
import { CompanyComponent } from './company/company.component';
import { ExchangeComponent } from './exchange/exchange.component';
import { IPOComponent } from './ipo/ipo.component';
import { IpodisplayComponent } from './ipodisplay/ipodisplay.component';
import {​​ ChartsModule, ThemeService }​​ from 'ng2-charts';
import { ChartsComponent } from './charts/charts.component';
import { ProductService } from './Shared/product.service';
import { Router} from '@angular/router';
import { SectorchartComponent } from './sectorchart/sectorchart.component'; 

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AdminHomeComponent,
    UserHomeComponent,
    SignupComponent,
    CompanyComponent,
    ExchangeComponent,
    IPOComponent,
    IpodisplayComponent,
    ChartsComponent,
    SectorchartComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ChartsModule
  ],
  providers: [ThemeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
