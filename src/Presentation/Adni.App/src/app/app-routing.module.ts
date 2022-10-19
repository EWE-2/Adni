import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardFeatureComponent } from './features/admin/dashboard-feature/dashboard-feature.component';
import { AddEmployeeComponent } from './features/admin/Employee/add-employee/add-employee.component';
import { EmployeeDetailsComponent } from './features/admin/Employee/employee-details/employee-details.component';
import { EmployeesListComponent } from './features/admin/Employee/employees-list/employees-list.component';
import { AddEnterpriseComponent } from './features/admin/entreprise/add-enterprise/add-enterprise.component';
import { EnterpriseDetailsComponent } from './features/admin/entreprise/enterprise-details/enterprise-details.component';
import { EntrepriseListComponent } from './features/admin/entreprise/entreprise-list/entreprise-list.component';
import { EntrepriseComponent } from './features/admin/entreprise/entreprise.component';
import { UpdateEnterpriseComponent } from './features/admin/entreprise/update-enterprise/update-enterprise.component';
import { AddAlumniUserComponent } from './features/admin/insertion-pro/add-alumni-user/add-alumni-user.component';
import { AlumniUserDetailsComponent } from './features/admin/insertion-pro/alumni-user-details/alumni-user-details.component';
import { InsertionProComponent } from './features/admin/insertion-pro/insertion-pro.component';
import { UpdateAlumniUserComponent } from './features/admin/insertion-pro/update-alumni-user/update-alumni-user.component';
import { MiseEnStageComponent } from './features/admin/mise-en-stage/mise-en-stage.component';
import { NewProspectionComponent } from './features/admin/prospection/new-prospection/new-prospection.component';
import { PlacesDispoComponent } from './features/admin/prospection/places-dispo/places-dispo.component';
import { ProspectionComponent } from './features/admin/prospection/prospection.component';
import { ProspectionsListComponent } from './features/admin/prospection/prospections-list/prospections-list.component';
import { UpdateProspectionComponent } from './features/admin/prospection/update-prospection/update-prospection.component';
import { RapportStageComponent } from './features/admin/rapport-stage/rapport-stage.component';
import { RapportComponent } from './features/admin/rapport/rapport.component';
import { RecommendationComponent } from './features/admin/recommendation/recommendation.component';
import { StageComponent } from './features/admin/stage/stage.component';
import { AddStudentComponent } from './features/admin/student/add-student/add-student.component';
import { ListStudentsComponent } from './features/admin/student/list-students/list-students.component';
import { StudentDetailsComponent } from './features/admin/student/student-details/student-details.component';
import { StudentComponent } from './features/admin/student/student.component';
import { UpdateStudentComponent } from './features/admin/student/update-student/update-student.component';
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
      { path: 'board', component: DashboardFeatureComponent },
      { path: 'employees', component: EmployeesListComponent },
      { path: 'employees/add', component: AddEmployeeComponent },
      { path: 'employees/details/{:id}', component: EmployeeDetailsComponent},
      // { path: 'employee/update/{:id}' },
      /*companies endpoints*/
      {
        path: 'companies',
        component: EntrepriseComponent,
        children: [
          { path: '', component: EntrepriseListComponent },
          { path: 'add', component: AddEnterpriseComponent },
          { path: 'update/{:id}', component: UpdateEnterpriseComponent },
          { path: 'details/{:id}', component: EnterpriseDetailsComponent },
        ],
      },
      /** insertion professionnelle */
      { path: 'inspro', component: InsertionProComponent },
      { path: 'inspro/alumni/add-user', component: AddAlumniUserComponent },
      { path: 'inspro/alumni/user/details/{:id}', component: AlumniUserDetailsComponent },
      { path: 'inspro/alumni/user/update/{:id}', component: UpdateAlumniUserComponent },
      /**Mise en stage */
      { path: 'mise-stage', component: MiseEnStageComponent },
      /**Prospection */
      { path: 'prospection', component: ProspectionComponent },
      { path: 'prospection/new', component: NewProspectionComponent },
      { path: 'prospection/list', component: ProspectionsListComponent },
      { path: 'prospection/update/{:id}', component: UpdateProspectionComponent },
      { path: 'prospection/{:id}/placedispo', component: PlacesDispoComponent },
      /**Rapport d'activite */
      { path: 'report', component: RapportComponent },
      /**Rapport de stage */
      { path: 'rapport-stage', component: RapportStageComponent },
      /**Recommendations */
      { path: 'recommendation', component: RecommendationComponent },
      /**Stage */
      { path: 'intern', component: StageComponent },
      /**Students */
      {
        path: 'students',
        component: StudentComponent,
        children: [
          { path: 'add', component: AddStudentComponent },
          { path: 'list', component: ListStudentsComponent },
          { path: '{:id}', component:  StudentDetailsComponent },
          { path: 'update/{:id}', component: UpdateStudentComponent },
        ],
      }
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
