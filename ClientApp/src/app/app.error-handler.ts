import { ToastyService } from 'ng2-toasty';
import { ErrorHandler, Inject, NgZone, isDevMode } from '@angular/core';
import * as Sentry from '@sentry/browser';

Sentry.init({
    dsn: 'https://95c7ae3d480d4256866272bd0da0ef70:4308837c32c7498ba955ecaa7f9e1a3a@sentry.io/1500157'
  });

export class AppErrorHandler implements ErrorHandler {

    constructor(private ngZone: NgZone, @Inject(ToastyService) private toastyService: ToastyService) {
    }

    handleError(error: any): void {

      this.ngZone.run(() => {
        this.toastyService.error({
          title: 'Error',
          msg: 'An unexpected error happend',
          theme: 'bootstrap',
          showClose: true,
          timeout: 5000
        });
      });

      if (!isDevMode()) {
        const eventId = Sentry.captureException(error.originalError || error);
        // Sentry.showReportDialog({ eventId });
      } else {
        throw error;
      }

    }
}
