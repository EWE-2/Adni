import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NgChartsModule } from 'ng2-charts';
import { ReactiveFormsModule } from '@angular/forms';

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
import { DoughnutComponent } from './components/admin/chart/doughnut/doughnut.component';
import { AlmniSignUpComponent } from './features/auth/almni-sign-up/almni-sign-up.component';
import { AlumniLogInComponent } from './features/auth/alumni-log-in/alumni-log-in.component';

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
    AddEmployeeComponent,
    DoughnutComponent,
    AlmniSignUpComponent,
    AlumniLogInComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, AppRoutingModule, NgChartsModule, ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
