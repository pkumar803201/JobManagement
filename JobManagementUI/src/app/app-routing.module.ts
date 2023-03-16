import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddJobComponent } from './components/add-job/add-job.component';
import { JobsComponent } from './components/jobs/jobs.component';

const routes: Routes = [
  { path: '', component: JobsComponent },
  { path: 'add-job', component: AddJobComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
