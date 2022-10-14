import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError, Observable, tap, throwError } from 'rxjs';
import { ICompany } from 'src/app/models/Company';
import { environment } from 'src/environments/environment';
import { IStudent } from '../../../models/student';

@Injectable({
  providedIn: 'root'
})
export class DashboardEltsService {
  /**Observable for student */
  srcStd$: Observable<IStudent> = new Observable();
  constructor(private http: HttpClient) { }

  /** Getting companies */
  public getCompanies(): Observable<ICompany[]>{
    return this.http.get<ICompany[]>(environment.baseUrl + "api/v1.0/Companies").pipe(
      tap(companies => console.log("companies ", companies)),
      catchError(this.handleError)
    );
  }
  public countCompanies(){
    return 5;
  }

  /** Getting students count */
  public getStudents(): Observable<IStudent[]> {
    return this.http.get<IStudent[]>(environment.baseUrl + "api/v1.0/Student").pipe(
      tap(students => console.log("Etudiants ", students)),
      catchError(this.handleError)
    );
  }

  public countStudents() {
    return 5;
  }

  /**request error handlingERROR */
  private handleError(error: HttpErrorResponse){
    if (error.error instanceof ErrorEvent){
      console.error('Une erreur est survenu', error.error.message);
    } else {
      console.error(
        'Code de Backend ${error.status}, ' +
        'le contenu du corps est: ${error.error}'
      );
    }

    return throwError(() => {
      const error: any = Error("Une erreur est survenue; veillez reesayer plutard");
      return error;
    });
  }
}
