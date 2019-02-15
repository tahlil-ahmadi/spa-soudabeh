import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { TreeViewModule } from '@progress/kendo-angular-treeview';
import { DialogsModule } from '@progress/kendo-angular-dialog';
import { CourseCategoryListComponent } from './course-category-list/course-category-list.component';
import { CourseListComponent } from './course-list/course-list.component';
import { CourseCategoryService } from './shared/course-category.service';
import { CourseCategoryItemComponent } from './course-category-item/course-category-item.component';


//TODO: move to seperate module
const routes : Routes =[
  { path: 'course-category-list', component: CourseCategoryListComponent },
  { path: 'course-list', component: CourseListComponent },
];

@NgModule({
  declarations: [
    CourseCategoryListComponent,
    CourseListComponent,
    CourseCategoryItemComponent,
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes),  //TODO: describe forRoot & forChild

    TreeViewModule,
    DialogsModule,
  ],
  providers:[
    CourseCategoryService
  ],
  entryComponents:[
    CourseCategoryItemComponent
  ]
})
export class CourseModule {
  
}
