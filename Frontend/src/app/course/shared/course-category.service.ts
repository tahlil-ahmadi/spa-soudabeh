import { Observable } from "rxjs";
import { CourseCategory } from "./course-category";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class CourseCategoryService {

    constructor(private http: HttpClient) {
    }

    getAll() : Observable<Array<CourseCategory>> {
        //TODO: remove hard coded url
        return this.http.get<Array<CourseCategory>>("http://localhost:5000/api/CourseCategories");
    }

    save(model: CourseCategory) : Observable<any> {
        //TODO: remove hard coded url
        if (model.id)
            return this.http.put("http://localhost:5000/api/CourseCategories/" + model.id,model);
        else
            return this.http.post("http://localhost:5000/api/CourseCategories",model);
    }

    delete(id: number): Observable<any> {
        //TODO: remove hard coded url
        return this.http.delete("http://localhost:5000/api/CourseCategories/" + id);
    }

    getById(id: number): Observable<CourseCategory> {
        //TODO: remove hard coded url
        return this.http.get<CourseCategory>("http://localhost:5000/api/CourseCategories/" + id);
    }
}