import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MenuBarComponent } from './menu-bar/menu-bar.component';

@NgModule({
  declarations: [MenuBarComponent],
  imports: [
    CommonModule,
    RouterModule,
  ],
  exports: [
    MenuBarComponent
  ]
})
export class LayoutModule { }
