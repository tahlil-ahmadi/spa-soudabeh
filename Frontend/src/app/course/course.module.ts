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
import { CoreModule } from '../core/core.module';
import { AuthGuard } from '../auth/shared/auth-guard.service';
import { GridModule } from '@progress/kendo-angular-grid';


//TODO: move to seperate module
const routes : Routes =[
  { path: 'course-category-list', component: CourseCategoryListComponent, canActivate:[AuthGuard] },
  { path: 'course-list', component: CourseListComponent, canActivate:[AuthGuard] },
];

@NgModule({
  declarations: [
    CourseCategoryListComponent,
    CourseListComponent,
    CourseCategoryItemComponent,
  ],
  imports: [
    CommonModule,
    CoreModule,
    FormsModule,
    RouterModule.forRoot(routes),  //TODO: describe forRoot & forChild

    TreeViewModule,
    DialogsModule,
    GridModule
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
