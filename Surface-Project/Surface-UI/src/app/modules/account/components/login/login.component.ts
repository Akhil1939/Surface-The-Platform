import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Login } from '../../interfaces/login';
import { LanguageService } from 'src/app/modules/shared/services/language.service';
import { AccountService } from '../../services/account.service';
declare var require: any;
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  constructor(
    private languageService: LanguageService,
    private accountService: AccountService
  ) {}

  language: string = this.languageService.getLanguage();
  translator: any = require(`../../../../../assets/languages/${this.language}.json`);

  updatedLanguage = this.languageService.language$.subscribe((language) => {
    this.language = language;
    console.log(language);
    this.translator = require(`../../../../../assets/languages/${this.language}.json`);
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
        console.log(res);
      });
    } else {
      console.log('invalid');
    }
  }
}
