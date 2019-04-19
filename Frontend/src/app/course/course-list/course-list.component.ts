import { Component, OnInit } from '@angular/core';
import { CourseCategoryService } from '../shared/course-category.service';
import { CourseCategory } from '../shared/course-category';
import { Observable } from 'rxjs';
import { GridDataResult, DataStateChangeEvent } from '@progress/kendo-angular-grid';
import { State } from '@progress/kendo-data-query';
import { CourseService } from '../shared/course.service';

@Component({
  selector: 'app-course-list',
  templateUrl: './course-list.component.html',
  styleUrls: ['./course-list.component.css']
})
export class CourseListComponent implements OnInit {
  
  private view: Observable<GridDataResult>;
  public state: State = {
    skip: 0,
    take: 10
  };

  constructor(private service: CourseService) { }
  
  ngOnInit(): void {
    this.view = this.service.getForGrid(this.state);
  }


  public dataStateChange(state: DataStateChangeEvent) {
    this.state = state;
    this.view = this.service.getForGrid(this.state);
  }
}
