import { Component, OnInit, AfterViewInit, ViewChild, ElementRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { createPopper } from '@popperjs/core';
import { environment } from 'src/environments/environment';
import { Employee } from 'src/app/models/employee';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {
  public employees?: Employee[];
  public status: Status[] = [
    { color: 'green', text: 'En ligne'},
    { color: 'red', text: 'Hors ligne'}
  ];

  //Table dropdown
  dropdownPopoverShow = false;
  @ViewChild("btnDropdownRef", { static: false }) btnDropdownRef!: ElementRef;
  @ViewChild("popoverDropdownRef", { static: false })
  popoverDropdownRef!: ElementRef;
  ngAfterViewInit() {
    createPopper(
      this.btnDropdownRef.nativeElement,
      this.popoverDropdownRef.nativeElement,
      {
        placement: "bottom-start",
      }
    );
  }
  toggleDropdown(event: { preventDefault: () => void; }) {
    event.preventDefault();
    if (this.dropdownPopoverShow) {
      this.dropdownPopoverShow = false;
    } else {
      this.dropdownPopoverShow = true;
    }
  }
  //table dropdown: End

  constructor(private http: HttpClient) {
    http.get<Employee[]>(environment.baseUrl + 'api/v1.0/Employies').subscribe(result => {
      this.employees = result;
    }, error => console.error(error));
   }

  ngOnInit(): void {
  }
}

interface Status {
  color: string,
  text: string
}
