import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICustomRegistration } from '../interfaces/accountInterfaces/registration';
import { BASE_ROUTE, LOGIN_URL, REGISTER_URL } from '../constants/routeConst';


@Injectable({
  providedIn: 'root',
})
export class AccountService {
  constructor(private httpClient: HttpClient) {
    console.log('Hello Account Service Provider');
  }

  //register method to call api
  customRegister(data: ICustomRegistration) {
    return this.httpClient.post(BASE_ROUTE + REGISTER_URL, data);
  }

  continueWithGoogle(data: any) {
    return this.httpClient.post(
      BASE_ROUTE + 'Account/continueWithGoogle',
      data
    );
  }

  // login method to call api
  login(data: any) {
    return this.httpClient.post(BASE_ROUTE + LOGIN_URL, data);
  }
}
