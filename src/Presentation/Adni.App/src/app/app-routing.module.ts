import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardFeatureComponent } from './features/admin/dashboard-feature/dashboard-feature.component';
import { AddEmployeeComponent } from './features/admin/Employee/add-employee/add-employee.component';
import { EmployeesListComponent } from './features/admin/Employee/employees-list/employees-list.component';
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
