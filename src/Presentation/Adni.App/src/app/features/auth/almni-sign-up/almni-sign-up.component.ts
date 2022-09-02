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
      userName: new FormControl(''),
      email: new FormControl(''),
      normalizedEmail: new FormControl(''),
      passwordHash: new FormControl(''),
      firtname: new FormControl(''),
      lastname: new FormControl(''),
      gender: new FormControl(''),
      fieldId: new FormControl(''),
      graduateYear: new FormControl(''),
      phoneNumber: new FormControl(''),
      dob: new FormControl(''),
      proStatus: new FormControl(''),
      companyId: new FormControl(''),
      position:new FormControl('')
    });
  }

  onSubmit(){
    var user: AlmUser = {
      userName: this.form.controls['firstname'].value,
      email: this.form.controls['email'].value,
      normalizedEmail: this.form.controls['email'].value,
      passwordHash: this.form.controls['email'].value + this.form.controls['gender'].value,
      firtname: this.form.controls['firstname'].value,
      lastname: this.form.controls['lastname'].value,
      gender: this.form.controls['gender'].value,
      fieldId: this.form.controls['field'].value,
      graduateYear: this.form.controls['gradyear'].value,
      phoneNumber: this.form.controls['phoneNumber'].value,
      dob: this.form.controls['dob'].value,
      proStatus: this.form.controls['prostatus'].value,
      companyId: this.form.controls['company'].value,
      position: this.form.controls['position'].value,
      location: this.form.controls['position'].value
    };
    var url = environment.baseUrl + 'api/auth/alumni/inscription';

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
