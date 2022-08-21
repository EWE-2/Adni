import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public forecasts?: WeatherForecast[];

  constructor(http: HttpClient) {
    http.get<WeatherForecast[]>('/api/v1.0/Employies').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }

  title = 'Adni';
}

interface WeatherForecast {
  IsOnline: boolean;
  Role: string;
  FirstName: string;
  Lastname: string;
  Username: string;
  Password: string;
  Location: string;
  Phonenumber: string;
  WhatsappNumber: string;
  DoB: string;
  EmployeeId: string;
}
