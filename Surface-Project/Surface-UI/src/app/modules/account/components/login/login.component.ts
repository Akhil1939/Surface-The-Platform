import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Login } from '../../interfaces/login';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm:FormGroup = new FormGroup({});
  loginCredentials : Login={
    email:'',
    password:''
  }
  constructor() { 
  }
  ngOnInit(): void {
    this.loginForm = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required])
    });
  }

  login() {
    // Here you can access the loginForm's values, including email and password.
    if(this.loginForm.valid){

      console.log(this.loginForm.value);
    }else{

      console.log("invalid")
    }
  }

}
