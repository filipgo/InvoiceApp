import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
// import { DecimalPipe } from '@angular/common';
// import { DatePipe } from '@angular/common';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AddInvoiceComponent } from './add-invoice/add-invoice.component';
import { BrowseInvoiceComponent } from './browse-invoice/browse-invoice.component';
import { SeeEditInvoiceComponent } from './see-edit-invoice/see-edit-invoice.component';
import { SeeInvoiceComponent } from './see-invoice/see-invoice.component';
import { InvoiceService } from './services/invoice.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    AddInvoiceComponent,
    BrowseInvoiceComponent,
    SeeInvoiceComponent,
    SeeEditInvoiceComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserAnimationsModule,
    // DatePipe,
    // DecimalPipe,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: BrowseInvoiceComponent, pathMatch: 'full' },
      // { path: 'counter', component: CounterComponent },
      // { path: 'fetch-data', component: FetchDataComponent },
      { path: 'add', component: AddInvoiceComponent},
      // { path: 'browse-invoice', component: BrowseInvoiceComponent},
      { path: 'invoice/:id', component: SeeInvoiceComponent},
      { path: 'invoice/edit/:id', component: SeeEditInvoiceComponent},
      { path: '**', redirectTo: '/' }
    ])
  ],
  providers: [
    InvoiceService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
