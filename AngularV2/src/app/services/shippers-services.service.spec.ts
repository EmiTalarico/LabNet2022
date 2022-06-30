import { TestBed } from '@angular/core/testing';

import { ShippersServicesService } from './shippers-services.service';

describe('ShippersServicesService', () => {
  let service: ShippersServicesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ShippersServicesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
