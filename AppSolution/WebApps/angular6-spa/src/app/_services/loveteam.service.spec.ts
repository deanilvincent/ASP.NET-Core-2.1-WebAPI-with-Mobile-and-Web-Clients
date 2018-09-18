/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { LoveteamService } from './loveteam.service';

describe('Service: Loveteam', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LoveteamService]
    });
  });

  it('should ...', inject([LoveteamService], (service: LoveteamService) => {
    expect(service).toBeTruthy();
  }));
});
