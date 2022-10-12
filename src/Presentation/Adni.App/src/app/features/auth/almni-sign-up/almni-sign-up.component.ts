import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { IAlmUser } from 'src/app/models/AlmUser';

import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-almni-sign-up',
  templateUrl: './almni-sign-up.component.html',
  styleUrls: ['./almni-sign-up.component.css']
})
export class AlmniSignUpComponent implements OnInit {
  form!: FormGroup;
  almUser?: IAlmUser;

  constructor( private http: HttpClient) { }

  ngOnInit(): void {
    this.form = new FormGroup({
      email: new FormControl(''),
      firtname: new FormControl(''),
      lastname: new FormControl(''),
      gender: new FormControl(''),
      fieldId: new FormControl(''),
      graduateYears: new FormControl(''),
      phoneNumber: new FormControl(''),
      dob: new FormControl(''),
      proStatus: new FormControl(''),
      company: new FormControl(''),
      position:new FormControl(''),
      localisation: new FormControl(''),
      contrat: new FormControl(''),
    });
  }

  onSubmit(){
    var user: IAlmUser = {
      UserName: this.form.controls['firtname'].value,
      Email: this.form.controls['email'].value,
      NormalizedEmail: this.form.controls['email'].value,
      PasswordHash: this.form.controls['email'].value + this.form.controls['gender'].value,
      Firtname: this.form.controls['firtname'].value,
      Lastname: this.form.controls['lastname'].value,
      Gender: this.form.controls['gender'].value,
      FieldId: this.form.controls['fieldId'].value,
      GraduateYear: this.form.controls['graduateYears'].value,
      PhoneNumber: this.form.controls['phoneNumber'].value,
      Dob: this.form.controls['dob'].value,
      ProStatus: this.form.controls['proStatus'].value,
      CompanyId: this.form.controls['company'].value,
      Position: this.form.controls['position'].value,
      Contrat: this.form.controls['contrat'].value,
      UserLocation: this.form.controls['localisation'].value,
      AlmUserId: '',
      Companylocalisation: '',
      WhatsappNumber: this.form.controls['phoneNumber'].value,
      ImageDirectory: ''
    };
    var url = environment.baseUrl + 'api/v1.0/AlmUser/ajouter';

    this.http
      .post<IAlmUser>(url, user)
      .subscribe(result => {

        console.log("L'utilisateur" + result.Firtname + "nous a rejoint");
      }, error => console.error(error));
  }

}

enum ProStatus{
  Employe,
  Freelance,
  Stage
}

enum Contrat{
  CDI,
  CDD
}
