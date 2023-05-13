import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  values = [];
  myNumber = 10;
  constructor(private http: HttpClient) {
    http.get('/api/number').subscribe((values: number[]) => this.values = values);
  }
  onAddNumber() {
    this.values.push(this.myNumber);
    this.http.post('/api/number', this.myNumber).subscribe();
    this.myNumber++;
  }
}
