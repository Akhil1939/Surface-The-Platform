import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormGroup, FormControl, Validators, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Login } from '../../../interfaces/accountInterfaces/login';
import { AccountService } from '../../../services/account.service';
import { LanguageService } from '../../../services/common/language.service';
import { Router, RouterModule } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, RouterModule,MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,FormsModule, ReactiveFormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  constructor(
    private languageService: LanguageService,
    private accountService: AccountService,
    private router:Router 
  ) {}

  language: string = this.languageService.getLanguage();
  // translator: any = require(`../../../../../assets/languages/${this.language}.json`);

  updatedLanguage = this.languageService.language$.subscribe((language) => {
    this.language = language;
    console.log(language);
    // this.translator = require(`../../../../../assets/languages/${this.language}.json`);
  });

  loginForm: FormGroup = new FormGroup({});
  loginCredentials: Login = {
    email: '',
    password: '',
  };
  ngOnInit(): void {
    this.loginForm = new FormGroup({
      email: new FormControl(this.loginCredentials.email, [
        Validators.required,
        Validators.email,
      ]),
      password: new FormControl(this.loginCredentials.password, [
        Validators.required,
      ]),
    });
  }

  login() {
    // Here you can access the loginForm's values, including email and password.
    if (this.loginForm.valid) {
      console.log(this.loginForm.value);
      this.accountService.login(this.loginForm.value).subscribe((res) => {
        this.router.navigate(['/']) 
        console.log(res);
      });
    } else { 
      console.log('invalid');
    }
  }
}
