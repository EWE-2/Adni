import { environment } from 'src/environments/environment';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IAlmUser } from 'src/app/models/AlmUser';
import { createPopper } from '@popperjs/core';

@Component({
  selector: 'app-insertion-pro',
  templateUrl: './insertion-pro.component.html',
  styleUrls: ['./insertion-pro.component.css']
})
export class InsertionProComponent implements OnInit {
  public almUsers?: IAlmUser[];

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
    http.get<IAlmUser[]>(environment.baseUrl + "api/v1.0/AlmUser").subscribe( result => {
      this.almUsers = result;
    }, error => console.error(error));
  }

  ngOnInit(): void {
  }

}
