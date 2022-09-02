import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEnterpriseComponent } from './add-enterprise.component';

describe('AddEnterpriseComponent', () => {
  let component: AddEnterpriseComponent;
  let fixture: ComponentFixture<AddEnterpriseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEnterpriseComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddEnterpriseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
