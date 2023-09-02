import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse,
  HttpResponse
} from '@angular/common/http';
import { Observable, catchError, finalize, tap } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { SnackbarConfig } from '../modules/shared/models/SnackbarConfig';
import { SnackbarService } from '../modules/shared/services/snackbar.service';
import { SpinnerService } from '../modules/shared/services/spinner.service';


@Injectable()
export class BaseInterceptor implements HttpInterceptor {

  constructor(private spinningService : SpinnerService, private snackbarService: SnackbarService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    
    this.spinningService.showSpinner();

    request = request.clone({
      setHeaders: {
        'X-Api-Version': environment.apiVersion,
        'credentials': 'include',
      },
      withCredentials: true,
    });
    
    return next.handle(request).pipe(
      tap((event: HttpEvent<any>) => {
        if(event instanceof HttpResponse && (request.method == "POST" || request.method == "PUT" || request.method == "DELETE") && (event.status == 200 || event.status >= 200 && event.status < 300)){
          const snackbarConfig:SnackbarConfig = new SnackbarConfig({
            message: event.body?.message ?? "Operation completed successfully",
            status: "success",
            duration: 3000,
        });
        this.snackbarService.show(snackbarConfig);
      }
    }),
      catchError((error: HttpErrorResponse) => {
        // show error details
        const snackbarConfig:SnackbarConfig = new SnackbarConfig({
          message: error.error?.message ?? "Internal server error",
          status: "error",
          duration: 3000,
        });
        this.snackbarService.show(snackbarConfig);
        throw error;
      }),
      finalize(() => this.spinningService.hideSpinner()),
    );
  }
}
