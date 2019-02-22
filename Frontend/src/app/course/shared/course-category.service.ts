import { Observable } from "rxjs";
import { CourseCategory } from "./course-category";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment.prod";
import { RestService } from "src/app/core/services/rest.service";

@Injectable()
export class CourseCategoryService {
    private resourceName ="CourseCategories";

    constructor(private restService: RestService) {
    }

    getAll() : Observable<Array<CourseCategory>> {
        return this.restService.getAll(this.resourceName);
    }

    save(model: CourseCategory) : Observable<any> {
        if (model.id)
            return this.restService.put(this.resourceName,model.id, model);
        else
            return this.restService.post(this.resourceName, model);
    }

    delete(id: number): Observable<any> {
        return this.restService.delete(this.resourceName, id);
    }

    getById(id: number): Observable<CourseCategory> {
        return this.restService.getById(this.resourceName, id);
    }

   
}