import { Injectable } from '@angular/core';
import { UserManager, User } from 'oidc-client';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private userManager: UserManager;
  private user: User;
  constructor(private router: Router) {

    const settings = {
      authority: 'http://localhost:5000/',
      client_id: 'academy-soudabeh',
      redirect_uri: 'http://localhost:4200/auth-callback',
      response_type: "code",
      scope: "openid profile soudabeh-api",
      response_mode: "query"
    }
    this.userManager = new UserManager(settings);
    this.userManager.getUser().then(user=> this.user = user);
  }

  redirectToSts(url: string) {
      this.userManager.signinRedirect({state:url});
  }

  redirectCallback(){
    this.userManager.signinRedirectCallback().then(user => {
      this.user = user;
      this.router.navigate([user.state]);
    });
  }

  getToken() : string {
    return this.user.token_type + " " + this.user.access_token;
  }

  isUserLoggedIn(){
    return this.user != null;
  }
}
