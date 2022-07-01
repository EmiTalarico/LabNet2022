import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ListadoShippersComponent } from './components/listado-shippers/listado-shippers.component';
import { AgregarShippersComponent } from './components/agregar-shippers/agregar-shippers.component';
import { EliminarShippersComponent } from './components/eliminar-shippers/eliminar-shippers.component';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ListadoShippersComponent,
    AgregarShippersComponent,
    EliminarShippersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
