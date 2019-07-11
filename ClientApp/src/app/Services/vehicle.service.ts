import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { map } from 'rxjs/operators';
import { SaveVehicle } from '../models/vehicle';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {
  private readonly vehiclesEndpoint = '/api/vehicles';
  constructor(private http: Http) { }

  getFeatures() {
    return this.http.get('/api/features').pipe(map(res => res.json()));
  }

  getMakes() {
    return this.http.get('/api/makes')
      .pipe(map(res => res.json()));
  }

  create(vehicle) {
    return this.http.post(this.vehiclesEndpoint, vehicle)
      .pipe(map(res => res.json()));
  }

  getVehicle(id) {
    return this.http.get(this.vehiclesEndpoint + '/' + id)
      .pipe(map(res => res.json()));
  }

  getVehicles(filter) {
    return this.http.get(this.vehiclesEndpoint + '?' + this.toQueryString(filter))
      .pipe(map(res => res.json()));
  }

  toQueryString(obj) {
    // tslint:disable-next-line:no-var-keyword
    // tslint:disable-next-line:prefer-const
    let parts = [];
    // tslint:disable-next-line:forin
    for (const property in obj) {
      const value = obj[property];
      if (value != null && value !== undefined) {
        parts.push(encodeURIComponent(property) + '=' + encodeURIComponent(value));
      }
    }

    return parts.join('&');
  }

  update(vehicle: SaveVehicle) {
    return this.http.put(this.vehiclesEndpoint + '/' + vehicle.id, vehicle)
      .pipe(map(res => res.json()));
  }

  delete(id) {
    return this.http.delete(this.vehiclesEndpoint + '/' + id)
      .pipe(map(res => res.json()));
  }
}
