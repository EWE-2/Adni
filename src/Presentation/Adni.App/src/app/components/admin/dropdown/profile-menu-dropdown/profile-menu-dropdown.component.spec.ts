import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfileMenuDropdownComponent } from './profile-menu-dropdown.component';

describe('ProfileMenuDropdownComponent', () => {
  let component: ProfileMenuDropdownComponent;
  let fixture: ComponentFixture<ProfileMenuDropdownComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfileMenuDropdownComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProfileMenuDropdownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
