import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetCatComponent } from './get-cat.component';

describe('GetCatComponent', () => {
  let component: GetCatComponent;
  let fixture: ComponentFixture<GetCatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetCatComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetCatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
