import { Component } from '@angular/core';
import { ChartConfiguration, ChartType, ChartData, ChartEvent } from 'chart.js';

@Component({
  selector: 'app-doughnut',
  templateUrl: './doughnut.component.html',
  styleUrls: ['./doughnut.component.css']
})
export class DoughnutComponent {
  public doughnutChartLabels: string[] = ['En stage', 'Non en stage'];
  public doughnutChartData: ChartData<'doughnut'> = {
    labels: this.doughnutChartLabels,
    datasets: [
      { data: [50, 150], backgroundColor: ['#7e3af2', '#1c64f2',] } ,
    ]
  };
  public doughnutChartType: ChartType = 'doughnut';

  // events
  public chartClick({ event, active }: { event: ChartEvent, active: {}[] }): void {
    console.log(event, active);
  }

  public chartHover({ event, active }: { event: ChartEvent, active: {}[] }): void {
    console.log(event, active);
  }

  constructor() { }
}
