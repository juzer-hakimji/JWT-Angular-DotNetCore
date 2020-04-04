import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { FormControl, FormGroup } from '@angular/forms';
import { map } from 'rxjs/operators';
import { User } from '../Extras/user';

@Component({
  selector: 'app-prac-dd',
  templateUrl: './prac-dd.component.html',
  styleUrls: ['./prac-dd.component.css']
})
export class PracDdComponent implements OnInit {

  Emllst;
  Burl;

  myGroup = new FormGroup({
    NullEmp : new FormControl(null)
  });


  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.Burl = baseUrl;
    this.http.get(baseUrl + 'api/SampleData/GetData').subscribe(data => this.Emllst = data)
  }

  ngOnInit() {

  }

  CheckData() {
    var formValue = this.myGroup.value;
    //this.http.post(this.Burl + 'api/SampleData/CheckData', { Id: formValue.NullEmp }).subscribe(data => console.log('success', data));
    this.http.get(this.Burl + 'api/SampleData/CheckData' + '/' + formValue.NullEmp).subscribe(data => console.log('success', data));
  }

  login() {
    let obj = { token: 'test' };
    const headerOptions = new HttpHeaders({ 'Content-Type': 'application/json' });
    this.http.post<any>(this.Burl + 'api/SampleData', obj)
      .pipe(map(user => {
        // login successful if there's a jwt token in the response
        if (user && user.token) {
          // store user details and jwt token in local storage to keep user logged in between page refreshes
          localStorage.setItem('currentUser', JSON.stringify(user));
        }

        return user;
      })).subscribe(x => console.log("success"));
  }

  GetListOfEmp() {
    this.http.get(this.Burl + 'api/SampleData/GetAll').subscribe(data => console.log('success', data));
  }

  logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('currentUser');
    console.log("Done");
  }
}
