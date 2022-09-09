import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { AlmUser } from 'src/app/models/AlmUser';

import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-almni-sign-up',
  templateUrl: './almni-sign-up.component.html',
  styleUrls: ['./almni-sign-up.component.css']
})
export class AlmniSignUpComponent implements OnInit {
  form!: FormGroup;
  almUser?: AlmUser;

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
    var user: AlmUser = {
      userName: this.form.controls['firtname'].value,
      email: this.form.controls['email'].value,
      normalizedEmail: this.form.controls['email'].value,
      passwordHash: this.form.controls['email'].value + this.form.controls['gender'].value,
      firtname: this.form.controls['firtname'].value,
      lastname: this.form.controls['lastname'].value,
      gender: this.form.controls['gender'].value,
      fieldId: this.form.controls['fieldId'].value,
      graduateYear: this.form.controls['graduateYears'].value,
      phoneNumber: this.form.controls['phoneNumber'].value,
      dob: this.form.controls['dob'].value,
      proStatus: this.form.controls['proStatus'].value,
      companyId: this.form.controls['company'].value,
      position: this.form.controls['position'].value,
      contrat: this.form.controls['contrat'].value,
      localisation: this.form.controls['localisation'].value
    };
    var url = environment.baseUrl + 'api/v1.0/AlmUser/ajouter';

    this.http
      .post<AlmUser>(url, user)
      .subscribe(result => {

        console.log("L'utilisateur" + result.firtname + "nous a rejoint");
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
