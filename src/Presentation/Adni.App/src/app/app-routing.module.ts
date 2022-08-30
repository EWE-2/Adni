import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardFeatureComponent } from './features/admin/dashboard-feature/dashboard-feature.component';
import { AddEmployeeComponent } from './features/admin/Employee/add-employee/add-employee.component';
import { EmployeesListComponent } from './features/admin/Employee/employees-list/employees-list.component';
import { AlmniSignUpComponent } from './features/auth/almni-sign-up/almni-sign-up.component';
import { AlumniLogInComponent } from './features/auth/alumni-log-in/alumni-log-in.component';
import { LoginComponent } from './features/auth/login/login.component';
import { LoadComponent } from './features/loading/load/load.component';
import { AdminlayoutComponent } from './layouts/adminlayout/adminlayout.component';
import { AuthComponent } from './layouts/auth/auth.component';

const routes: Routes = [
  {
    path: 'auth',
    component: AuthComponent,
    children: [
      { path: 'login', component: LoginComponent },
      { path: 'alumni/inscription', component: AlmniSignUpComponent},
      { path: 'alumni/login', component: AlumniLogInComponent },
    ]
  },
  {
    path: 'admin',
    component: AdminlayoutComponent,
    children: [
      { path: '', component: DashboardFeatureComponent },
      { path: 'employees', component: EmployeesListComponent },
      { path: 'employees/add', component: AddEmployeeComponent },
    ]
  },
  { path: '', component: LoadComponent, pathMatch: 'full'},
];


@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
