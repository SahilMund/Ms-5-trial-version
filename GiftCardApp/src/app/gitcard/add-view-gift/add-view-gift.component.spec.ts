import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddViewGiftComponent } from './add-view-gift.component';

describe('AddViewGiftComponent', () => {
  let component: AddViewGiftComponent;
  let fixture: ComponentFixture<AddViewGiftComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddViewGiftComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddViewGiftComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
