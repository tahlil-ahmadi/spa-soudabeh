import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RestService {
  
  constructor(private httpClient: HttpClient) {  }

  getAll<T>(resourceName: string): Observable<Array<T>> {
    var url = this.getUrl(resourceName);
    return this.httpClient.get<Array<T>>(url);
  }

  getById<T>(resourceName: string, id: number): Observable<T> {
    var url = this.getUrl(resourceName, id);
    return this.httpClient.get<T>(url);
  }
  delete(resourceName: string, id: number): Observable<any> {
    var url = this.getUrl(resourceName, id);
    return this.httpClient.delete(url);
  }

  post(resourceName: string, model: any): Observable<any> {
    var url = this.getUrl(resourceName);
    return this.httpClient.post(url, model);
  }
  put(resourceName: string, id: number, model: any): Observable<any> {
    var url = this.getUrl(resourceName, id);
    return this.httpClient.put(url, model);
  }

  private getUrl(resourceName: string, id?: number) {
    let url =  `${environment.baseUrl}${resourceName}`;
    if (id)
      url += "/" + id;
    return url;
  }
}
