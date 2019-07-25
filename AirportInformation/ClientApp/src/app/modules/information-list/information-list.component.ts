import { Component, OnInit } from '@angular/core';
import { GetPortsService } from 'src/app/services/get-ports.service';
import AirportDTO from 'src/app/DTOs/AirportDTO';

@Component({
  selector: 'app-information-list',
  templateUrl: './information-list.component.html',
  styleUrls: ['./information-list.component.css']
})
export class InformationListComponent implements OnInit {

  ports: AirportDTO[];
  constructor(private ps: GetPortsService) { }

  ngOnInit() {
    this.ps
      .getPorts()
      .subscribe((data: AirportDTO[]) => {
        this.ports = data;
      });
  }

}
