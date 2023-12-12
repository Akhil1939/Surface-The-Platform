import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatDialog } from '@angular/material/dialog';
import { MediaObserver } from '@angular/flex-layout';
import { EditProjectDialogComponent } from '../../edit-project-dialog/edit-project-dialog.component';
import { IProjectDetail } from '../../../../interfaces/project_interfaces/iProjectDetail.interface';
import { FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ISelect } from '../../../../interfaces/InputInterfaces/ISelect.Interface';
@Component({
  selector: 'app-header',
  standalone: true,
  imports: [
    CommonModule,
    MatButtonModule,
    MatMenuModule,
    MatIconModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
})
export class HeaderComponent {
  @Input() projectDetails!: IProjectDetail;
  statusControl = new FormControl(7);
  statusGroups: ISelect[] = [
    { value: 7, viewValue: 'Planning' },
    { value: 8, viewValue: 'Active' },
    { value: 9, viewValue: 'On Hold' },
    { value: 10, viewValue: 'Completed' },
    { value: 11, viewValue: 'Cancelled' },
  ];

  constructor(
    private dialog: MatDialog,
    private mediaObserver: MediaObserver
  ) {}

  openUpdateProjectDialog() {
    this.dialog.open(EditProjectDialogComponent);
  }
  private calculateDialogWidth(): string {
    const extraSmallWidth = '100%';
    const smallWidth = '100%';
    const mediumWidth = '70%';
    const largeWidth = '50%';
    const extraLargeWidth = '50%';

    const screenSize = this.mediaObserver.isActive('lt-xs')
      ? 'extraSmall'
      : this.mediaObserver.isActive('lt-sm')
      ? 'small'
      : this.mediaObserver.isActive('lt-md')
      ? 'medium'
      : this.mediaObserver.isActive('lt-lg')
      ? 'large'
      : 'extraLarge';

    switch (screenSize) {
      case 'extraSmall':
        return extraSmallWidth;
      case 'small':
        return smallWidth;
      case 'medium':
        return mediumWidth;
      case 'large':
        return largeWidth;
      case 'extraLarge':
        return extraLargeWidth;
      default:
        return mediumWidth; // Default width for unhandled breakpoints
    }
  }
}
