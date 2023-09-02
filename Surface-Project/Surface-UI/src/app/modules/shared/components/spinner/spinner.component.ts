import { Component, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs/internal/Subscription';
import { SpinnerService } from '../../services/spinner.service';

@Component({
  selector: 'app-spinner',
  templateUrl: './spinner.component.html',
  styleUrls: ['./spinner.component.scss']
})
export class SpinnerComponent implements OnDestroy {
  
  isSpinning: boolean = false;
  private spinningSubscription : Subscription;

  constructor(private spinningService : SpinnerService) {
    this.spinningSubscription = this.spinningService.spinning$.subscribe(isSpinning => {
      this.isSpinning = isSpinning;
    });
  }

  ngOnDestroy() {
      this.spinningSubscription.unsubscribe();
    }
  }
