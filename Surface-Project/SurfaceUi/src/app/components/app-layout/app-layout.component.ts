import {
  AfterViewInit,
  Component,
  ElementRef,
  Inject,
  ViewChild,
} from '@angular/core';
import { CommonModule, DOCUMENT } from '@angular/common';
import { SidebarComponent } from './sidebar/sidebar.component';
import { RouterModule, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [CommonModule, SidebarComponent, RouterOutlet, RouterModule],
  templateUrl: './app-layout.component.html',
  styleUrl: './app-layout.component.css',
})
export class AppLayoutComponent {
  @ViewChild('sidebar') sidebar!: ElementRef;
  @ViewChild(SidebarComponent) sidebarComponent: SidebarComponent | undefined;

  constructor(@Inject(DOCUMENT) private document: Document) {}
  ngAfterViewInit() {
    if (this.sidebarComponent) {
      const toggle: ElementRef | undefined = this.sidebarComponent.toggle;
      const searchBtn: ElementRef | undefined = this.sidebarComponent.searchBtn;
      const modeSwitch: ElementRef | undefined =
        this.sidebarComponent.modeSwitch;
      const modeText: ElementRef | undefined = this.sidebarComponent.modeText;

      toggle.nativeElement.addEventListener('click', () => {
        this.sidebar?.nativeElement.classList.toggle('close');
      });

      searchBtn.nativeElement.addEventListener('click', () => {
        console.log('search');
        this.sidebar?.nativeElement.classList.remove('close');
      });

      modeSwitch?.nativeElement.addEventListener('click', () => {
        console.log('mode clicked');
        this.document.body.classList.toggle('dark');
        console.log('change mode to dark');
        if (this.document.body.classList.contains('dark')) {
          modeText.nativeElement.innerText = 'Light mode';
        } else {
          modeText.nativeElement.innerText = 'Dark mode';
        }
      });
    }
  }
}
