import { Component, OnInit } from '@angular/core';
import { CourseCategoryService } from '../shared/course-category.service';
import { CourseCategory } from '../shared/course-category';
import { of, Observable } from 'rxjs';
import { DialogService } from '@progress/kendo-angular-dialog';
import { CourseListComponent } from '../course-list/course-list.component';
import { CourseCategoryItemComponent } from '../course-category-item/course-category-item.component';

@Component({
  selector: 'app-course-category-list',
  templateUrl: './course-category-list.component.html',
  styleUrls: ['./course-category-list.component.css']
})
export class CourseCategoryListComponent implements OnInit {

  courseCategories: Array<CourseCategory>;
  constructor(private service: CourseCategoryService,
              private dialogService: DialogService) { }

  ngOnInit() {
    this.reloadTree();
  }
  addRoot() {
    this.openDialog(null);
  }
  edit(model : CourseCategory) {
    this.openDialog(model.id);
  }
  private openDialog(id: number) {
    const dialogRef = this.dialogService.open({
      title: 'Please confirm',
      content: CourseCategoryItemComponent,
    });

    dialogRef.content.instance.id = id;
    dialogRef.result.subscribe(result => {
      if (result == true) {
        this.reloadTree();
      }
    });
  }

  delete(model : CourseCategory) {
    if (confirm("are you sure?")){
      this.service.delete(model.id).subscribe(a=> this.reloadTree());
    }
  }

  private reloadTree() {
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
  fetchChildren(model: CourseCategory) :Observable<Array<CourseCategory>> {
    return of(model.children);
  }
}
