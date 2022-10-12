import { Injectable } from '@angular/core';
import { IStudent } from '../../../models/student';

@Injectable({
  providedIn: 'root'
})
export class DashboardEltsService {

  constructor() { }

  public getStudents(): IStudent[] {
    return [
      {
        StudentId: "0fbf76ec-d9e1-48de-acbf-c9042c09c9f7",
        Firstname: "ONANA",
        Lastname: "Leonel",
        Gender: "M",
        Email: "onana@gmail.com",
        PhoneNumber: "+23769999999",
        UserLocation: "Pk 17",
        Dob: "28 Fev 1997",
        ImageDirectory: "assets/img/logos/logo_enspd.png",
        Matricule: "17G03952",
        AcademicYear: "2022-2023",
        AcademicLevel: 4,
        FieldId: "0fbf76ec-d9e1-48de-acbf-c9042c09c9f8",
      },
      {
        StudentId: "0fbf76ec-d1e1-48de-acbf-c9042c09c9f7",
        Firstname: "SONIA",
        Lastname: "Sonia",
        Gender: "F",
        Email: "sonia@gmail.com",
        PhoneNumber: "+23765999999",
        UserLocation: "Yassa'a",
        Dob: "30 Janv 1997",
        ImageDirectory: "assets/img/logos/logo_enspd.png",
        Matricule: "17G01952",
        AcademicYear: "2022-2023",
        AcademicLevel: 4,
        FieldId: "0fbf76ec-d9e1-48de-acbf-c9042c09c9f8",
      }
    ];
  }

  public countStudents() {
    return this.getStudents().length;
  }
}
