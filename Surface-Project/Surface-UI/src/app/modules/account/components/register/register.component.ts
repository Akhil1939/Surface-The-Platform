import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  registrationForm:FormGroup=new FormGroup({});
  constructor() { }
  ngOnInit(){
    this.registrationForm=new FormGroup({
      firstName:new FormControl('',[Validators.required]),
      lastName:new FormControl('',[Validators.required]),
      email:new FormControl('',[Validators.required,Validators.email]),
      password:new FormControl('',[Validators.required]),
      confirmPassword:new FormControl('',[Validators.required])
    })
  }
   
  register(){
    if(this.registrationForm.valid){
      console.log(this.registrationForm.value);
    }else{
      console.log("invalid")
    }
  }
}
