import { Observable } from "rxjs";
import { CourseCategory } from "./course-category";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment.prod";

@Injectable()
export class CourseCategoryService {
    private resourceName ="CourseCategories";

    constructor(private http: HttpClient) {
    }

    getAll() : Observable<Array<CourseCategory>> {
        return this.http.get<Array<CourseCategory>>(this.getUrl());
    }

    save(model: CourseCategory) : Observable<any> {
        if (model.id)
            return this.http.put(this.getUrl(model.id),model);
        else
            return this.http.post(this.getUrl(),model);
    }

    delete(id: number): Observable<any> {
        return this.http.delete(this.getUrl(id));
    }

    getById(id: number): Observable<CourseCategory> {
        return this.http.get<CourseCategory>(this.getUrl(id));
    }

    private getUrl(id?: number) {
        return `${environment.baseUrl}${this.resourceName}/${id}`;
    }
}