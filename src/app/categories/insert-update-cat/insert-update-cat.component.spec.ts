import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsertUpdateCatComponent } from './insert-update-cat.component';

describe('InsertUpdateCatComponent', () => {
  let component: InsertUpdateCatComponent;
  let fixture: ComponentFixture<InsertUpdateCatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsertUpdateCatComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InsertUpdateCatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
