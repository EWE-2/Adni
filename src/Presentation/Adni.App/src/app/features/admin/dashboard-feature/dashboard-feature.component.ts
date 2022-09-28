import { Component, OnInit } from '@angular/core';
import { ChartConfiguration, ChartType, ChartData, ChartEvent } from 'chart.js';

@Component({
  selector: 'app-dashboard-feature',
  templateUrl: './dashboard-feature.component.html',
  styleUrls: ['./dashboard-feature.component.css']
})
export class DashboardFeatureComponent implements OnInit {
  title = 'tableau de bord';
  options? = {
    layers: [
      tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', { maxZoom: 18, attribution: '...' })
    ],
    zoom: 5,
    center: latLng(46.879966, -121.726909)
  };

  constructor() { }

  ngOnInit(): void {
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
