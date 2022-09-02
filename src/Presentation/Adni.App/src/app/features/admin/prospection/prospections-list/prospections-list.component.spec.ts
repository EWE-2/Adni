import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProspectionsListComponent } from './prospections-list.component';

describe('ProspectionsListComponent', () => {
  let component: ProspectionsListComponent;
  let fixture: ComponentFixture<ProspectionsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProspectionsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProspectionsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
