import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/internal/BehaviorSubject';

@Injectable({
  providedIn: 'root'
})
export class SpinnerService {

  constructor() { }

  private spinningSubject = new BehaviorSubject<boolean>(false);
  spinning$ = this.spinningSubject.asObservable();

  showSpinner() {
    this.spinningSubject.next(true);
  }

  hideSpinner() {
    this.spinningSubject.next(false); 
  }

}
