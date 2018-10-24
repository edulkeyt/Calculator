import { TestBed, inject } from '@angular/core/testing';

import { CalculateApiService } from './calculate-api.service';

describe('CalculateApiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CalculateApiService]
    });
  });

  it('should be created', inject([CalculateApiService], (service: CalculateApiService) => {
    expect(service).toBeTruthy();
  }));
});
