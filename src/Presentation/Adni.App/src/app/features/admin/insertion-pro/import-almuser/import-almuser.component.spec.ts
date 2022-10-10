import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ImportAlmuserComponent } from './import-almuser.component';

describe('ImportAlmuserComponent', () => {
  let component: ImportAlmuserComponent;
  let fixture: ComponentFixture<ImportAlmuserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ImportAlmuserComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ImportAlmuserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
