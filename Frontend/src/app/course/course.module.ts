import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { CourseCategoryListComponent } from './course-category-list/course-category-list.component';
import { CourseListComponent } from './course-list/course-list.component';

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
    RouterModule.forRoot(routes)  //TODO: describe forRoot & forChild
  ]
})
export class CourseModule {
  
}
