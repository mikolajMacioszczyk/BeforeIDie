import { TestBed } from '@angular/core/testing';

import { GoalsRealizedService } from './goals-realized.service';

describe('GoalsRealizedService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: GoalsRealizedService = TestBed.get(GoalsRealizedService);
    expect(service).toBeTruthy();
  });
});
