import { Component, OnInit } from '@angular/core';
import { trigger, state, style, transition, animate } from '@angular/animations';


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

  constructor() { }

  toggleProfileMenu(){
    this.isOpen = !this.isOpen;
  }

  ngOnInit(): void {
  }

}
