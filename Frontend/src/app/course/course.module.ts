import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { TreeViewModule } from '@progress/kendo-angular-treeview';
import { CourseCategoryListComponent } from './course-category-list/course-category-list.component';
import { CourseListComponent } from './course-list/course-list.component';
import { CourseCategoryService } from './shared/course-category.service';


//TODO: move to seperate module
const routes : Routes =[
  { path: 'course-category-list', component: CourseCategoryListComponent },
  { path: 'course-list', component: CourseListComponent },
];

@NgModule({
  declarations: [
    CourseCategoryListComponent,
    CourseListComponent,
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    TreeViewModule,
    RouterModule.forRoot(routes)  //TODO: describe forRoot & forChild
  ],
  providers:[
    CourseCategoryService
  ]
})
export class CourseModule {
  
}
