import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-forgot-password',
  templateUrl: './forgot-password.component.html',
  styleUrls: ['./forgot-password.component.css']
})
export class ForgotPasswordComponent {
form:FormGroup=new FormGroup({});
  constructor() { }

  ngOnInit(): void {
    this.form=new FormGroup({
      email:new FormControl('',[Validators.required,Validators.email]),
    })
  }
  sendMail(){
    if(this.form.valid){
      console.log(this.form.value);
    }else{
      console.log("invalid")
    }
  }
}
