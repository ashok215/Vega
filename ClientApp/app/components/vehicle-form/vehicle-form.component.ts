import { VehicleService } from './../../services/vehicle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css'],
  providers:[VehicleService]
})
export class VehicleFormComponent implements OnInit {
makes:any[];
models:any[]; 
vehicle:any={};
features:any[];

constructor( private vehicleService:VehicleService) { }

  ngOnInit() {

  //  this.vehicleService.getMakes().subscribe(makes=>this.makes=makes);

  //  this.vehicleService.getFeature().subscribe(features=>this.features=features);
   this.vehicleService.getMakes().subscribe(makes => 
      this.makes = makes);

    this.vehicleService.getFeatures().subscribe(features => 
      this.features = features);
  }

onMakechange()
{
  var selectedMake=this.makes.find(m=>m.id==this.vehicle.id);
  this.models=selectedMake ?selectedMake.models:[];
}}
