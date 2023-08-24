import { Component } from '@angular/core';
import { LocalStorageService } from './modules/shared/services/local-storage.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Surface-UI';
constructor(private storage:LocalStorageService ){
  if(this.storage.get('language')===null){
    this.storage.set('language','en')
  }

}
}
