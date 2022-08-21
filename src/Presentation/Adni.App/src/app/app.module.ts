import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LayoutsModule } from './layouts/layouts.module';
import { FeaturesModule } from './features/features.module';
import { LoginComponent } from './features/auth/login/login.component';
import { AuthHeaderComponent } from './partials/headers/auth-header/auth-header.component';
import { AdminHeaderComponent } from './partials/headers/admin-header/admin-header.component';
import { AuthComponent } from './layouts/auth/auth.component';
import { LoadComponent } from './features/loading/load/load.component';
import { AppRoutingModule } from './app-routing.module';
import { NavbarAdminComponent } from './partials/admin/navbar-admin/navbar-admin.component';
import { AdminlayoutComponent } from './layouts/adminlayout/adminlayout.component';
import { DashboardFeatureComponent } from './features/admin/dashboard-feature/dashboard-feature.component';
import { EmployeesListComponent } from './features/admin/Employee/employees-list/employees-list.component';
import { AddEmployeeComponent } from './features/admin/Employee/add-employee/add-employee.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AuthHeaderComponent,
    AdminHeaderComponent,
    AuthComponent,
    LoadComponent,
    NavbarAdminComponent,
    AdminlayoutComponent,
    DashboardFeatureComponent,
    EmployeesListComponent,
    AddEmployeeComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
