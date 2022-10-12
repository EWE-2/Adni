import { Component, OnInit } from '@angular/core';
import { ChartConfiguration, ChartType, ChartData, ChartEvent } from 'chart.js';
import { DashboardEltsService } from './dashboard-elts.service';

@Component({
  selector: 'app-dashboard-feature',
  templateUrl: './dashboard-feature.component.html',
  styleUrls: ['./dashboard-feature.component.css']
})
export class DashboardFeatureComponent implements OnInit {
  title = 'tableau de bord';
  /* ================= Introduire une carte du cameroun dans le dashboard pour les zones de stages avec la librairie leaflet */
  // options? = {
  //   layers: [
  //     tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', { maxZoom: 18, attribution: '...' })
  //   ],
  //   zoom: 5,
  //   center: latLng(46.879966, -121.726909)
  // };

  /**============= Number of students for students card in the dashboard ==============*/
  // services import
  public stdCount! : number;

  constructor(private studentCountService: DashboardEltsService) { }

  ngOnInit(): void {
    this.stdCount = this.studentCountService.countStudents();
    console.log(5);
  }

  //
  public internlabel: string[] = ['En stage', 'Hors stage'];
  public interndataset: ChartData<'doughnut'> = {
    labels: this.internlabel,
    datasets: [
      { data: [ 1058, 450 ] }
    ]
  };

  public typechart: ChartType = 'doughnut';
  public interoptions: ChartConfiguration<'doughnut'>['options'] = {
    responsive: true
  };

  // events
  public chartClicked({ event, active }: { event: ChartEvent, active: {}[] }): void {
    console.log(event, active);
  }

  public chartHovered({ event, active }: { event: ChartEvent, active: {}[] }): void {
    console.log(event, active);
  }

}
