import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormGroup,
  FormControl,
  Validators,
  FormsModule,
  ReactiveFormsModule,
} from '@angular/forms';
import { ICustomRegistration } from '../../../interfaces/accountInterfaces/registration';
import { AccountService } from '../../../services/account.service';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    RouterModule,
    HttpClientModule,
  ],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent {
  registrationForm: FormGroup = new FormGroup({});

  user: ICustomRegistration = {
    firstName: '',
    email: '',
    password: '',
    lastName: '',
    loginProviderId: 0,
    loginToken: '',
  };
  constructor(private accountService: AccountService) {}

  ngOnInit() {
    this.registrationForm = new FormGroup({
      firstName: new FormControl('', [Validators.required]),
      lastName: new FormControl(''),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required]),
      confirmPassword: new FormControl('', [Validators.required]),
    });
  }

  register() {
    if (this.registrationForm.valid) {
      this.user.email = this.registrationForm.get('email')?.value;
      this.user.password = this.registrationForm.get('password')?.value;
      this.user.firstName = this.registrationForm.get('firstName')?.value;
      this.user.lastName = this.registrationForm.get('lastName')?.value;
      this.user.loginProviderId = 1;
      this.user.loginToken = '';

      console.log(this.user);
      this.accountService.customRegister(this.user).subscribe((data) => {
        console.log(data);
      });
    } else {
      console.log('invalid');
    }
  }
}
