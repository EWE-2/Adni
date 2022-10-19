import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ICompany } from 'src/app/models/Company';
import { createPopper } from '@popperjs/core';

@Component({
  selector: 'app-entreprise',
  templateUrl: './entreprise.component.html',
  styleUrls: ['./entreprise.component.css']
})
export class EntrepriseComponent implements OnInit {
  public companies?: ICompany[];



  constructor(private http: HttpClient) {
    http.get<ICompany[]>(environment.baseUrl + 'api/v1.0/Companies').subscribe(result => {
      this.companies = result;
    }, error => console.error(error));
   }

  ngOnInit(): void {
  }

}
