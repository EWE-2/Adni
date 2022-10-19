import { TestBed } from '@angular/core/testing';

import { DashboardEltsService } from './dashboard-elts.service';

describe('DashboardEltsService', () => {
  let service: DashboardEltsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DashboardEltsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
