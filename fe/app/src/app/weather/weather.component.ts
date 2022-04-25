import { Component, OnInit } from '@angular/core';
import { WeatherService } from './weather.service';
import { Weather } from './wheater';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent implements OnInit {
  weather: Weather[] = [];

  constructor(private weatherService: WeatherService) { }

  ngOnInit(): void {
    this.weatherService.getWeather().subscribe(w => this.weather = w);
  }
}
