import { Component, ElementRef, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-sidebar',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css'
})
export class SidebarComponent {
  @ViewChild('sidebar', { static: false }) sidebar: ElementRef<HTMLDivElement> | undefined;

  @ViewChild('toggle') toggle!: ElementRef;
  @ViewChild('searchBtn') searchBtn!: ElementRef;
  @ViewChild('modeSwitch') modeSwitch!: ElementRef;
  @ViewChild('modeText') modeText!: ElementRef;

  ngAfterViewInit() {
    // Access the native element after it's initialized
    
  }
}
