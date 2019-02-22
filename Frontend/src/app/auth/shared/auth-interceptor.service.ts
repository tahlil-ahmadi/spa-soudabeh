import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpEvent, HttpHandler, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthService } from './auth.service';

@Injectable({providedIn: 'root'})
export class TokenInterceptor implements HttpInterceptor {

    constructor(private authService: AuthService) {  }

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

        const token = this.authService.getToken();
        const authReq = req.clone({
            headers: req.headers.set('Authorization', token)
        });

        return next.handle(authReq);
    }
}