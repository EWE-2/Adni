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
import { ProspectionComponent } from './features/admin/prospection/prospection.component';
import { NewProspectionComponent } from './features/admin/prospection/new-prospection/new-prospection.component';
import { UpdateProspectionComponent } from './features/admin/prospection/update-prospection/update-prospection.component';
import { ProspectionsListComponent } from './features/admin/prospection/prospections-list/prospections-list.component';
import { StudentComponent } from './features/admin/student/student.component';
import { AddStudentComponent } from './features/admin/student/add-student/add-student.component';
import { UpdateStudentComponent } from './features/admin/student/update-student/update-student.component';
import { ListStudentsComponent } from './features/admin/student/list-students/list-students.component';
import { InsertionProComponent } from './features/admin/insertion-pro/insertion-pro.component';
import { AddAlumniUserComponent } from './features/admin/insertion-pro/add-alumni-user/add-alumni-user.component';
import { UpdateAlumniUserComponent } from './features/admin/insertion-pro/update-alumni-user/update-alumni-user.component';
import { AlumniUserDetailsComponent } from './features/admin/insertion-pro/alumni-user-details/alumni-user-details.component';
import { StudentDetailsComponent } from './features/admin/student/student-details/student-details.component';
import { PlacesDispoComponent } from './features/admin/prospection/places-dispo/places-dispo.component';
import { EmployeeDetailsComponent } from './features/admin/Employee/employee-details/employee-details.component';
import { MiseEnStageComponent } from './features/admin/mise-en-stage/mise-en-stage.component';
import { RecommendationComponent } from './features/admin/recommendation/recommendation.component';
import { RapportComponent } from './features/admin/rapport/rapport.component';
import { EntrepriseComponent } from './features/admin/entreprise/entreprise.component';
import { AddEnterpriseComponent } from './features/admin/entreprise/add-enterprise/add-enterprise.component';
import { UpdateEnterpriseComponent } from './features/admin/entreprise/update-enterprise/update-enterprise.component';
import { EnterpriseDetailsComponent } from './features/admin/entreprise/enterprise-details/enterprise-details.component';
import { StageComponent } from './features/admin/stage/stage.component';
import { RapportStageComponent } from './features/admin/rapport-stage/rapport-stage.component';
import { ImportAlmuserComponent } from './features/admin/insertion-pro/import-almuser/import-almuser.component';

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
    AlumniLogInComponent,
    ProspectionComponent,
    NewProspectionComponent,
    UpdateProspectionComponent,
    ProspectionsListComponent,
    StudentComponent,
    AddStudentComponent,
    UpdateStudentComponent,
    ListStudentsComponent,
    InsertionProComponent,
    AddAlumniUserComponent,
    UpdateAlumniUserComponent,
    AlumniUserDetailsComponent,
    StudentDetailsComponent,
    PlacesDispoComponent,
    EmployeeDetailsComponent,
    MiseEnStageComponent,
    RecommendationComponent,
    RapportComponent,
    EntrepriseComponent,
    AddEnterpriseComponent,
    UpdateEnterpriseComponent,
    EnterpriseDetailsComponent,
    StageComponent,
    RapportStageComponent,
    ImportAlmuserComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, AppRoutingModule, NgChartsModule, ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
