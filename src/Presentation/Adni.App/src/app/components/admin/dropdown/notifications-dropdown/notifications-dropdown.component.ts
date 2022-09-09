import { Component, AfterViewInit, ViewChild, ElementRef } from '@angular/core';
import { createPopper } from '@popperjs/core';

@Component({
  selector: 'app-notifications-dropdown',
  templateUrl: './notifications-dropdown.component.html',
  styleUrls: ['./notifications-dropdown.component.css']
})
export class NotificationsDropdownComponent implements AfterViewInit {
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
