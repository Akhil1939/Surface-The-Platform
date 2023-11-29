import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DateServiceService {

  constructor() { }
  getFormattedDate(): string {
    const options: Intl.DateTimeFormatOptions = { weekday: 'long', month: 'long', day: 'numeric' };
    const currentDate = new Date();
    return currentDate.toLocaleDateString('en-US', options);
  }

  getGreeting(): string {
    const currentHour = new Date().getHours();

    if (currentHour >= 5 && currentHour < 12) {
      return 'Good Morning';
    } else if (currentHour >= 12 && currentHour < 18) {
      return 'Good Afternoon';
    } else {
      return 'Good Evening';
    }
  }
}
