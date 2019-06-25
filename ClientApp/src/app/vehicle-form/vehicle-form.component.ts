import { MakeService } from './../Services/make.service';
import { Component, OnInit, NgModule } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  makes:any[];
  models:any[];
  vehicle:any = {};

  constructor(private makeService: MakeService) { }

  ngOnInit() {
    this.makeService.getMakes().subscribe(makes => 
      {
        this.makes = makes;
        //console.log(makes);
      });
  }

  onMakeChange(){
    var selectedMake = this.makes.find(x => x.id == this.vehicle.make);
    this.models = selectedMake ? selectedMake.models : [];
  }

}
