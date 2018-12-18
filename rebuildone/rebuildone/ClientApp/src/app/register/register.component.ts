import { Component, OnInit } from '@angular/core';
import { NgForm, Form } from '@angular/forms';
import { User } from '../models/user';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model = new User();
  constructor() { }

  ngOnInit() {
  }

  submit(form: Form) {
    console.log('Submitted');
    console.log(this.model);
    console.log(form);
  }
  onSubmit() {
    alert("Thanks for submitting! Data: " + JSON.stringify(this.model));
  }
}
