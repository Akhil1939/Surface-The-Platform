import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-reset-password',
  templateUrl: './reset-password.component.html',
  styleUrls: ['./reset-password.component.css']
})
export class ResetPasswordComponent implements OnInit {

  resetPasswordForm:FormGroup=new FormGroup({});
  constructor() { }
  
  ngOnInit(): void {
    this.resetPasswordForm=new FormGroup({
      newPassword:new FormControl('',[Validators.required]),
      confirmPassword:new FormControl('',[Validators.required])
    })
  }

  resetPassword(){
    if(this.resetPasswordForm.valid){
      console.log(this.resetPasswordForm.value);
    }else{
      console.log("invalid")
    }
  }

}
