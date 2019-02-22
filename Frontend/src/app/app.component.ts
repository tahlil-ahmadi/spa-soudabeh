import { Component } from '@angular/core';
import { UserManager } from 'oidc-client';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  

  login() {
    const settings = {
      authority: 'http://localhost:5000/',
      client_id: 'academy-soudabeh',
      redirect_uri: 'http://localhost:4200/auth-callback',
      response_type: "id_token token",
      scope: "openid profile soudabeh-api",
      loadUserInfo: true,
      filterProtocolClaims: true,
    }
    const userManager =new UserManager(settings);
    userManager.signinRedirect();
  }
}
