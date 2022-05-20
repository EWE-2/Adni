import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdninavbarComponent } from './adninavbar.component';

describe('AdninavbarComponent', () => {
  let component: AdninavbarComponent;
  let fixture: ComponentFixture<AdninavbarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdninavbarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdninavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
