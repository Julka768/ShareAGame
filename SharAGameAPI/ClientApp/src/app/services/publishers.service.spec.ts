/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PublishersService } from './publishers.service';

describe('Service: Publishers', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PublishersService]
    });
  });

  it('should ...', inject([PublishersService], (service: PublishersService) => {
    expect(service).toBeTruthy();
  }));
});
