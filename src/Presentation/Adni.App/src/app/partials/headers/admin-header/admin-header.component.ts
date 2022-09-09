import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { trigger, state, style, transition, animate } from '@angular/animations';
import { createPopper } from '@popperjs/core';


@Component({
  selector: 'app-admin-header',
  templateUrl: './admin-header.component.html',
  styleUrls: ['./admin-header.component.css'],
  animations: [
    trigger('opClose', [
      state('open', style({
        opacity: 1
      })),
      state('closed', style({
        opacity: 0
      })),
      transition('open => closed',
        [
          animate('0.5s ease-out', style({ opacity : 1 }))
        ]),
      transition('closed => open', [
          animate('0.5s ease-in', style({ opacity : 0 }))
        ]),
    ]),
  ]
})
export class AdminHeaderComponent implements OnInit {
  isOpen : boolean = false;
  dropdownPopoverShow = false;
  @ViewChild("btnDropdownRef", { static: false}) btnDropdownRef!: ElementRef;
  @ViewChild("popoverDropdownRef", { static: false }) popoverDropdownRef!: ElementRef;

  constructor() { }


  ngOnInit(): void {

  }



}
