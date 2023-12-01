import { Injectable, inject } from '@angular/core';
import {
  HttpRequest,
  HttpEvent,
  HttpErrorResponse,
  HttpResponse,
  HttpHandlerFn,
} from '@angular/common/http';
import { Observable, catchError, finalize, tap } from 'rxjs';
import { SnackbarConfig } from '../models/SnackbarConfig';
import { SnackbarService } from '../services/common/snackbar.service';
import { SpinnerService } from '../services/common/spinner.service';
import { environment } from '../environments/environment.development';

export function BaseInterceptor(
  req: HttpRequest<unknown>,
  next: HttpHandlerFn
): Observable<HttpEvent<unknown>> {
  const spinningService = inject(SpinnerService);
  const snackbarService = inject(SnackbarService);
  spinningService.showSpinner();

  req = req.clone({
    setHeaders: {
      'X-Api-Version': environment.apiVersion,
      credentials: 'include',
    },
    withCredentials: true,
  });

  return next(req).pipe(
    tap((event: HttpEvent<any>) => {
      if (
        event instanceof HttpResponse &&
        (req.method == 'POST' ||
          req.method == 'PUT' ||
          req.method == 'DELETE') &&
        (event.status == 200 || (event.status >= 200 && event.status < 300))
      ) {
        const snackbarConfig: SnackbarConfig = new SnackbarConfig({
          message: event.body?.message ?? 'Operation completed successfully',
          status: 'success',
          duration: 3000,
        });
        snackbarService.show(snackbarConfig);
      }
    }),
    catchError((error: HttpErrorResponse) => {
      console.log('get error');
      // show error details
      const snackbarConfig: SnackbarConfig = new SnackbarConfig({
        message: error.error?.message ?? 'Internal server error',
        status: 'error',
        duration: 3000,
      });
      snackbarService.show(snackbarConfig);
      throw error;
    }),
    finalize(() => spinningService.hideSpinner())
  );
}
