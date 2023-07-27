import { DOCUMENT } from '@angular/common';
import { Component, ElementRef, Inject, Renderer2 } from '@angular/core';
import { ScriptService } from '../../../services/script-service.service';
import { GoogleLoginProvider, SocialAuthService } from '@abacritt/angularx-social-login';
import { environment } from 'src/environments/environment.development';
import { Router } from '@angular/router';

declare let google: any;

@Component({
  selector: 'app-google',
  templateUrl: './google.component.html',
  styleUrls: ['./google.component.css']
})
export class GoogleComponent {
  SCRIPT_PATH='https://apis.google.com/js/platform.js'
  googleClientId: string = environment.googleClientId;
 
    constructor(private renderer: Renderer2,
      private googleAuthService: SocialAuthService,
      private router: Router,
      private elementRef: ElementRef,
      private scriptService: ScriptService) { 
    }
    ngOnInit() {
      const scriptElement = this.scriptService.loadJsScript(this.renderer, this.SCRIPT_PATH);
      scriptElement.onload = () => {
       console.log('Google API Script loaded');
        console.log(google);
  
        // Load the JavaScript client library.
        // (the init() method has been omitted for brevity)
        if (google?.accounts) {
          // Load the JavaScript client library.
          // (the init() method has been omitted for brevity)
          google.load('client', this.initializeGoogleSignIn.bind(this)); // Bind 'this' to the function
        } else {
          console.log('Google Accounts namespace not available.');
        }
      }
      scriptElement.onerror = () => {
        console.log('Could not load the Google API Script!');
      }
    }
    
    init(){
      console.log("time to run")
      this.initializeGoogleSignIn();
    }
    private initializeGoogleSignIn(): void {
      google.accounts.id.initialize({
        client_id: this.googleClientId,
        callback: this.handleCredentialResponse.bind(this),
      });
  console.log("Successfull init")
      const buttonDiv = this.elementRef.nativeElement.querySelector('#googleSignInButton');
      google.accounts.id.renderButton(buttonDiv, {
        theme: 'outline',
        size: 'large',
      });
      google.accounts.id.prompt(); // also display the One Tap dialog
    }
    private handleCredentialResponse(response: any): void {
      console.log('Encoded JWT ID token: ' + response.credential);
    }
  
    loginWithGoogle(): void {
      this.googleAuthService
        .signIn(GoogleLoginProvider.PROVIDER_ID)
        .then((user) => {
          console.log(user);
        });
    }
}
