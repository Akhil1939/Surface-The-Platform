import { Injectable, OnInit } from '@angular/core';
import { LocalStorageService } from './local-storage.service';
import { Observable, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LanguageService implements OnInit {

  constructor(private storage:LocalStorageService) { }
  private LANGUAGE = new Subject<any>();

 language$ = this.LANGUAGE.asObservable() ;


  setLanguage(language:string){
    this.storage.set('language',language);
    this.sendData(language);
  }
  getLanguage(){
    return this.storage.get('language');
  }
  
  sendData(data: any) {

    this.LANGUAGE.next(data);
  }

  ngOnInit(): void {
    this.sendData(this.getLanguage());
  }
}
