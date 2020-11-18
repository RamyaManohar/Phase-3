import { Component, OnInit } from '@angular/core';
import { User } from '../user';
import { ProductService } from '../Shared/product.service';
import { Router} from '@angular/router'; 

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  list :any ;
  username :string;
  password:string;
  usertype:string;
  user:User;
  id:number;
  email:string;
  mobile:number;

  constructor(private service : ProductService, private router:Router) { }
  

  ngOnInit() {
  }
  Login()
   {
     this.user = new User();
     this.user.Username = this.username;
     this.user.Password = this.password;
     this.user.UserType = this.usertype;
     console.log(this.user);

     if(this.usertype == "User")
     {
      this.service.userLogin(this.user).subscribe(i=>{
       
        if (i.toString()=="User logged in")
        {
          this.service.username = this.username;
          this.service.usertype = this.usertype;
          this.router.navigateByUrl('/userhome');
        }
        else
        this.router.navigateByUrl('/login');
      });
     }
     else if(this.usertype == "Admin")
     {
      this.service.adminLogin(this.user).subscribe(i=>{
        console.log(i.toString());
        if (i.toString()=="Admin logged in")
        {
          this.service.username = this.username;
          this.service.usertype = this.usertype;
          this.router.navigateByUrl('/adminhome');
        }
        else
        this.router.navigateByUrl('/login');
      })
     }
      
  
   }
  
}
