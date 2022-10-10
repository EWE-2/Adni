import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateEnterpriseComponent } from './update-enterprise.component';

describe('UpdateEnterpriseComponent', () => {
  let component: UpdateEnterpriseComponent;
  let fixture: ComponentFixture<UpdateEnterpriseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateEnterpriseComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateEnterpriseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
