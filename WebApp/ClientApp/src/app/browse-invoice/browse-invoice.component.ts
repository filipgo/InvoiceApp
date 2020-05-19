import { Component, OnInit } from '@angular/core';
import { InvoiceService } from '../services/invoice.service';

@Component({
  selector: 'app-browse-invoice',
  templateUrl: './browse-invoice.component.html',
  styleUrls: ['./browse-invoice.component.css']
})
export class BrowseInvoiceComponent implements OnInit {
  public invoiceData: Array<any>;
  public currentInvoice: any;

  constructor(private invoiceService: InvoiceService) {
    invoiceService.getAll().subscribe((data: any) => this.invoiceData = data);
  }

  ngOnInit() {
  }

}
