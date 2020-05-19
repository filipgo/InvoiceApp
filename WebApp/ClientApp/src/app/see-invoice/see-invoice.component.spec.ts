import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SeeInvoiceComponent } from './see-invoice.component';

describe('SeeInvoiceComponent', () => {
  let component: SeeInvoiceComponent;
  let fixture: ComponentFixture<SeeInvoiceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SeeInvoiceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SeeInvoiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
