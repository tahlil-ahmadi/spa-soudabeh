import { Component, OnInit } from '@angular/core';
import { CourseCategoryService } from '../shared/course-category.service';
import { CourseCategory } from '../shared/course-category';
import { of, Observable } from 'rxjs';

@Component({
  selector: 'app-course-category-list',
  templateUrl: './course-category-list.component.html',
  styleUrls: ['./course-category-list.component.css']
})
export class CourseCategoryListComponent implements OnInit {

  courseCategories: Array<CourseCategory>;
  constructor(private service: CourseCategoryService) { }

  ngOnInit() {
    this.service.getAll().subscribe(response => {
      this.courseCategories = response;
    });
  }

  hasChildren(model: CourseCategory) : boolean {
    if (model.children){
      return model.children.length > 0;
    }
    return false;
  }
  fetchChildren(model: CourseCategory) : Observable<Array<CourseCategory>> {
    return of(model.children);
  }

  delete(model : CourseCategory) {
    alert(model.id + " delete clicked !")
  }

  edit(model : CourseCategory) {
    alert(model.id + " edit clicked !")

  }
}
