import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SeeEditInvoiceComponent } from './see-edit-invoice.component';

describe('SeeEditInvoiceComponent', () => {
  let component: SeeEditInvoiceComponent;
  let fixture: ComponentFixture<SeeEditInvoiceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SeeEditInvoiceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SeeEditInvoiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
