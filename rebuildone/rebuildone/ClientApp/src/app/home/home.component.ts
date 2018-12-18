import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';
import { RouterModule, Routes } from '@angular/router';
import { RegisterComponent } from '../register/register.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  model = new User();
  constructor(private router: Router) {
  } 
  routes: Routes = [
    { path: 'register', component: RegisterComponent }
  ]

  ngOnInit() {
  }
}
