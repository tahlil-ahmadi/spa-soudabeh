import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export abstract class RestService<TKey, TModel> {

  constructor() { }
}
