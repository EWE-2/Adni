import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { createPopper } from '@popperjs/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Prospection } from 'src/app/models/prospection';

@Component({
  selector: 'app-prospection',
  templateUrl: './prospection.component.html',
  styleUrls: ['./prospection.component.css']
})
export class ProspectionComponent implements OnInit {
  public prospections?: any[];


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
    http.get<Prospection[]>(environment.baseUrl + 'api/v1.0/Prospection').subscribe(result => {
      this.prospections = result;
    }, error => console.error(error));
   }

  ngOnInit(): void {
  }

}
