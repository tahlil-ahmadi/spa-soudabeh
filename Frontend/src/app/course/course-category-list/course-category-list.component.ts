import { Component, OnInit } from '@angular/core';
import { CourseCategoryService } from '../shared/course-category.service';
import { CourseCategory } from '../shared/course-category';

@Component({
  selector: 'app-course-category-list',
  templateUrl: './course-category-list.component.html',
  styleUrls: ['./course-category-list.component.css']
})
export class CourseCategoryListComponent implements OnInit {

  constructor(private service: CourseCategoryService) { }

  ngOnInit() {
    this.service.getAll().subscribe(data=>{
      debugger;
    });
  }
}
