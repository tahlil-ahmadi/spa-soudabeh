import { Component, OnInit } from '@angular/core';
import { UserManager } from 'oidc-client';
import { AuthService } from './auth/shared/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
 
  private shouldShowPanel = false;

  constructor(private authService: AuthService, 
              private router: Router) { }

  ngOnInit(): void {
    if (!this.authService.isUserLoggedIn() && location.pathname != "/auth-callback"){
      this.authService.redirectToSts("");
    }
    else {
      this.shouldShowPanel = true;
    }
  }
  
}
