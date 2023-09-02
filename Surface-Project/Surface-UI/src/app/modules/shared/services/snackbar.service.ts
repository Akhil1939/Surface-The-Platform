import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { SnackbarConfig } from '../models/SnackbarConfig';
import { SnackbarComponent } from '../components/snackbar/snackbar.component';

@Injectable({
  providedIn: 'root'
})
export class SnackbarService {

  private statusConfigs: { [key: string]: { panelClass: string, icon: string } } = {
    'success': { panelClass: 'bg-success', icon: 'done' },
    'error': { panelClass: 'bg-error', icon: 'report-problem' },
    'warning': { panelClass: 'bg-warning', icon: 'warning_amber' },
    'info': { panelClass: 'bg-info', icon: 'info' },
  };

  constructor(private snackbar: MatSnackBar) {}

  show(config: SnackbarConfig) {
    const { status, message, action, duration, horizontalPosition, verticalPosition } = config;
    const statusConfig = this.statusConfigs[status ?? "success"] || {};
    const { panelClass, icon } = statusConfig;

    this.snackbar.openFromComponent(SnackbarComponent, {
      data: {
        message,
        action,
        status,
        icon,
        _snackbar: this.snackbar
      },
      duration,
      horizontalPosition,
      verticalPosition,
      panelClass
    });
  }
}
