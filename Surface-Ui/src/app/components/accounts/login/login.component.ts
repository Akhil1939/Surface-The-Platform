import {
  GoogleLoginProvider,
  SocialAuthService,
} from '@abacritt/angularx-social-login';
import { Component, ElementRef, Renderer2, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment.development';

interface GoogleSignIn {
  accounts: {
    id: {
      initialize(config: {
        client_id: string;
        callback: (response: any) => void;
      }): void;
      renderButton(
        element: HTMLElement,
        options: {
          theme: string;
          size: string;
        }
      ): void;
      prompt(): void;
    };
  };
}
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {
  @ViewChild('buttonDiv', { static: true }) buttonDivRef!: ElementRef;
  google: GoogleSignIn = (window as any).google;
  constructor(
    private googleAuthService: SocialAuthService,
    private router: Router,
    private renderer: Renderer2,
    private elementRef: ElementRef
  ) {}
  googleClientId: string = environment.googleClientId;

  ngOnInit(): void {
   
    this.initializeGoogleSignIn();

    this.googleAuthService.authState.subscribe((user) => {
      console.log('user', user);
      this.router.navigate(['/']);
    });
    this.googleAuthService.initState.subscribe((user) => {
      console.log('initState', user);
    }
    );
  }

  private initializeGoogleSignIn(): void {
    this.google.accounts.id.initialize({
      client_id: this.googleClientId,
      callback: this.handleCredentialResponse.bind(this),
    });

    const buttonDiv = this.elementRef.nativeElement.querySelector('#buttonDiv');
    this.google.accounts.id.renderButton(buttonDiv, {
      theme: 'outline',
      size: 'large',
    });
    // this.google.accounts.id.prompt(); // also display the One Tap dialog
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
