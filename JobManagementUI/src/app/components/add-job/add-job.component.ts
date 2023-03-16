import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { JobService } from 'src/app/services/job.service';

@Component({
  selector: 'app-add-job',
  templateUrl: './add-job.component.html',
  styleUrls: ['./add-job.component.css']
})
export class AddJobComponent implements OnInit {

jobForm=new FormGroup({
jobName : new FormControl('',[Validators.required]),
creator : new FormControl('prince.h.kumar@capgemini.com'),
pdfName : new FormControl('',[Validators.required]),
url : new FormControl('',[Validators.required]),
FromEmail : new FormControl('',[Validators.required,Validators.email]),
recipient : new FormControl('',[Validators.required,Validators.email]),
subject : new FormControl('',[Validators.required]),
body : new FormControl('',[Validators.required]),
scheduleType : new FormControl('',[Validators.required]),
status: new FormControl('success')
})

  constructor(private jobService:JobService){}
  ngOnInit(): void {

  }

addJob()
{
  console.warn(this.jobForm.value);
  this.jobService.AddJob(this.jobForm.value)
  .subscribe({
    next:(res)=>{
      alert("Product Added Successfully!")
    },
    error:(err)=>{
       alert("Something Wrong!")
    }
  })
}

get jobName()
{
  return this.jobForm.get('jobName');
}
get pdfName()
{
  return this.jobForm.get('pdfName');
}
get url()
{
  return this.jobForm.get('url');
}
get FromEmail()
{
  return this.jobForm.get('FromEmail');
}
get recipient()
{
  return this.jobForm.get('recipient');
}
get subject()
{
  return this.jobForm.get('subject');
}
get body()
{
  return this.jobForm.get('body');
}
get scheduleType()
{
  return this.jobForm.get('scheduleType');
}

}
