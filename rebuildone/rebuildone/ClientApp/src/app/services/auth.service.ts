import { Injectable } from '@angular/core';
import { AuthUser } from '../models/AuthUser';
import { JwtModule, JwtHelperService } from "@auth0/angular-jwt";
import { HttpClientModule } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})

export class AuthService {

  constructor() { }
  //I can't figure out how to get this code to compile and it breaks the app completely...
  /**
  Login(user) {
    return this.http.post<AuthUser>('api/auth/login', user)
      .pipe(map((result: AuthUser) => {
        if (result) {
          localStorage.setItem('token' , result.tokenString);
          localStorage.setItem('user', JSON.stringify(result.user));
        }
        return result;
      }));
    **/
  }
