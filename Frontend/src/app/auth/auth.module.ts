import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthCallbackComponent } from './auth-callback/auth-callback.component';
import { Routes, RouterModule } from '@angular/router';
import { TokenInterceptor } from './shared/auth-interceptor.service';
import { HTTP_INTERCEPTORS } from '@angular/common/http';

const routes : Routes =[
  { path: 'auth-callback', component: AuthCallbackComponent },
];

@NgModule({
  declarations: [AuthCallbackComponent],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  providers:[
    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true }
  ]
})
export class AuthModule { }
