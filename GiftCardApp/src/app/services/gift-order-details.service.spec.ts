import { TestBed } from '@angular/core/testing';

import { GiftOrderDetailsService } from './gift-order-details.service';

describe('GiftOrderDetailsService', () => {
  let service: GiftOrderDetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GiftOrderDetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
