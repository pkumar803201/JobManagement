import { Component, OnInit, ViewChild } from '@angular/core';
import { JobService } from 'src/app/services/job.service';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
@Component({
  selector: 'app-jobs',
  templateUrl: './jobs.component.html',
  styleUrls: ['./jobs.component.css']
})
export class JobsComponent implements OnInit {

  displayedColumns: string[] = ['jobName','scheduleType', 'scheduleDate','status','Date', 'creator','action'];
  dataSource!: MatTableDataSource<any>;
  currentDate=new Date();

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;


  constructor(private jobService:JobService){}
  ngOnInit(): void {
this.getAllJobDetails();
  }

  getAllJobDetails()
{
 this.jobService.getJobList()
 .subscribe({
  next:(res)=>{
    console.warn(res);
    this.dataSource=new MatTableDataSource(res);
    this.dataSource.paginator=this.paginator;
    this.dataSource.sort=this.sort;
  },
  error:(err)=>{
    alert("Error while fetching Products");
  }
 })

}

editJob(data:any)
{}
deleteJob(id:number)
{
  this.jobService.deleteJobDetails(id)
  .subscribe({
   next:(res)=>{
     alert('Job Deleted Successfully!');

    this.getAllJobDetails();
  },
  error:(err)=>{
     alert("Error while fetching Products");

  }
 })
}

applyFilter(event: Event) {
  const filterValue = (event.target as HTMLInputElement).value;
  this.dataSource.filter = filterValue.trim().toLowerCase();

  if (this.dataSource.paginator) {
    this.dataSource.paginator.firstPage();
  }
}


}
