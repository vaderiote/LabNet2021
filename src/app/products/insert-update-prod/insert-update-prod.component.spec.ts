import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsertUpdateProdComponent } from './insert-update-prod.component';

describe('InsertUpdateProdComponent', () => {
  let component: InsertUpdateProdComponent;
  let fixture: ComponentFixture<InsertUpdateProdComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsertUpdateProdComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InsertUpdateProdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
