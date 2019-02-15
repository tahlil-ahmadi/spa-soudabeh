import { Component, OnInit, Input } from '@angular/core';
import { CourseCategory } from '../shared/course-category';
import { CourseCategoryService } from '../shared/course-category.service';
import { DialogRef } from '@progress/kendo-angular-dialog';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-course-category-item',
  templateUrl: './course-category-item.component.html',
  styleUrls: ['./course-category-item.component.css']
})
export class CourseCategoryItemComponent implements OnInit {

  @Input() id:number;
  model = new CourseCategory();

  constructor(private dialogRef: DialogRef, private service: CourseCategoryService) { }

  ngOnInit() {
    if (this.id){
      this.service.getById(this.id).subscribe(response=> {
        this.model = response;
      });
    }
  }

  save() {
    this.service.save(this.model)
              .subscribe(a=> this.dialogRef.close(true));
  }

}
