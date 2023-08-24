import { Component } from '@angular/core';
import { LanguageService } from 'src/app/modules/shared/services/language.service';
import { LocalStorageService } from 'src/app/modules/shared/services/local-storage.service';

@Component({
  selector: 'app-account-layout',
  templateUrl: './account-layout.component.html',
  styleUrls: ['./account-layout.component.css']
})
export class AccountLayoutComponent {
  constructor(private language:LanguageService) { }
  switchToFr(){
    this.language.setLanguage('fr');

  }
  switchToEn(){
    this.language.setLanguage('en');

  }
}
