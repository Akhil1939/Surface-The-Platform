import { DOCUMENT } from '@angular/common';
import { Component, ElementRef, Inject, Renderer2 } from '@angular/core';
import { ScriptService } from '../../../services/script-service.service';
import {
  GoogleLoginProvider,
  SocialAuthService,
} from '@abacritt/angularx-social-login';
import { environment } from 'src/environments/environment.development';
import { Router } from '@angular/router';
import { AccountService } from '../../../services/account.service';

declare let google: any;
declare let gapi: any;
@Component({
  selector: 'app-google',
  templateUrl: './google.component.html',
  styleUrls: ['./google.component.css'],
})
export class GoogleComponent {
  SCRIPT_PATH = 'https://apis.google.com/js/platform.js';
  googleClientId: string = environment.googleClientId;
  constructor(
    private renderer: Renderer2,
    private googleAuthService: SocialAuthService,
    private router: Router,
    private elementRef: ElementRef,
    private scriptService: ScriptService,
    private accountService:AccountService
  ) {}
  GoogleToken={
    token:'',
  }
  ngOnInit() {
    const scriptElement = this.scriptService.loadJsScript(
      this.renderer,
      this.SCRIPT_PATH
    );
    scriptElement.onload = () => {
      console.log('Google API Script loaded');

      setTimeout(() => {
        if (google?.accounts) {
          console.log('Google', google);
          console.log('google account', google.accounts);
          console.log('gapi', gapi);
          gapi.load('client', this.initializeGoogleSignIn.bind(this)); // Bind 'this' to the function
        } else {
          console.log('Google Accounts namespace not available.');
        }
      }, 500);
    };
    scriptElement.onerror = () => {
      console.log('Could not load the Google API Script!');
    };
  }

  init() {
    console.log('time to run');
    this.initializeGoogleSignIn();
  }
  private initializeGoogleSignIn(): void {
    google.accounts.id.initialize({
      client_id: this.googleClientId,
      callback: this.handleCredentialResponse.bind(this),
    });
    console.log('Successful init');
    const buttonDiv = this.elementRef.nativeElement.querySelector(
      '#googleSignInButton'
    );
    google.accounts.id.renderButton(buttonDiv, {
      theme: 'outline',
      type: 'icon',
    });
    google.accounts.id.prompt(); // also display the One Tap dialog
  }
  private handleCredentialResponse(response: any): void {
    this.GoogleToken.token = response.credential
    console.log(this.GoogleToken, "token")
this.accountService.continueWithGoogle(this.GoogleToken).subscribe(res=>{
  console.log("Continew with google response", res);
})
  }

 
}
