/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { GetGameByIdResolverService } from './get-game-by-id-resolver.service';

describe('Service: GetGameByIdResolver', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [GetGameByIdResolverService]
    });
  });

  it('should ...', inject([GetGameByIdResolverService], (service: GetGameByIdResolverService) => {
    expect(service).toBeTruthy();
  }));
});
