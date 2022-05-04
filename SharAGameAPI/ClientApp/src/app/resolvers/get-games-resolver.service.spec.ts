/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { GetGamesResolverService } from './get-games-resolver.service';

describe('Service: GetGamesResolver', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [GetGamesResolverService]
    });
  });

  it('should ...', inject([GetGamesResolverService], (service: GetGamesResolverService) => {
    expect(service).toBeTruthy();
  }));
});
