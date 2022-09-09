import { AfterViewInit, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { createPopper } from '@popperjs/core';

@Component({
  selector: 'app-profile-menu-dropdown',
  templateUrl: './profile-menu-dropdown.component.html',
  styleUrls: ['./profile-menu-dropdown.component.css']
})
export class ProfileMenuDropdownComponent implements AfterViewInit {
  dropdownPopoverShow = false;
  @ViewChild("btnDropdownRef", { static: false}) btnDropdownRef!: ElementRef;
  @ViewChild("popoverDropdownRef", { static: false }) popoverDropdownRef!: ElementRef;

  constructor() { }

  ngAfterViewInit(): void {
    createPopper(
      this.btnDropdownRef.nativeElement,
      this.popoverDropdownRef.nativeElement,
      {
        placement:"left-end",
      }
    );
  }

  toggleProfileMenu(event:Event){
    event.preventDefault();
    if (this.dropdownPopoverShow){
      this.dropdownPopoverShow = false;
    } else {
      this.dropdownPopoverShow = true;
    }
  }

}
