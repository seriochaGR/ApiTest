import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InformationListComponent } from './modules/information-list/information-list.component';


const routes: Routes = [
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
