import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent {
  public home: Home = <Home>{};

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Home>(baseUrl + 'Home').subscribe(result => {
      this.home = result;
    }, error => console.error(error));
  }
}

interface Home {
  personsTotal: number;
  aliveTotal: number;
  deadTotal: number;
  gendersTotal: number;
//  personsTotalByGenders: { [key: string]: number; };
  personsTotalByGenders: KeyValuePair[];
//  personsTotalByGenders: Map<string, number>;
}

interface KeyValuePair {
  key: string;
  value: string;
}

//const map: Map<KeyType, ValueType> = new Map();
