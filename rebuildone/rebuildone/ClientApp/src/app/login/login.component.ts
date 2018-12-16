import { Component, OnInit } from '@angular/core';
import { NgForm, Form } from '@angular/forms';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  submit(form: Form) {
    console.log('Submitted');
    console.log(form);
  }
}
