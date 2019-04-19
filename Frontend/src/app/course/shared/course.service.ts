import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { GridDataResult } from '@progress/kendo-angular-grid';
import { State, toDataSourceRequestString } from '@progress/kendo-data-query';
import { RestService } from 'src/app/core/services/rest.service';

@Injectable({providedIn: 'root'})
export class CourseService {
    constructor(private restService: RestService) { }
    
    public getForGrid(state: State): Observable<GridDataResult> {
        var queryString = toDataSourceRequestString(state);
        return this.restService.get<GridDataResult>("Courses", queryString);
    }
}