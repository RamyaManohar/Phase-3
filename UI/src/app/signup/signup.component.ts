import { Component, OnInit } from '@angular/core';
import { User } from '../user';
import { ProductService } from '../Shared/product.service';
import { Router} from '@angular/router'; 

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
  id:number;
  username:string;
  password:string;
  usertype:string;
  email:string;
  mobile:number;
  user: User;
  constructor(private service : ProductService, private router:Router) {
    this.user = new User();
   }

  ngOnInit() {
  }
  Add()
  {
    this.user.Id = this.id;
    this.user.Username = this.username;
    this.user.Password = this.password;
    this.user.UserType = this.usertype;
    this.user.MobileNumber = this.mobile;
    this.user.EMail = this.email;
    this.user.Confirmed = "Yes";
    console.log(this.user);

    this.service.add(this.user).subscribe(i=>{
      console.log(i.toString());
    });
   
  }
  

}
