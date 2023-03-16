import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class JobService {

  readonly apiUrl ='https://localhost:7283/api/';
  constructor(private http:HttpClient) { }


  AddJob(data: any) {
    return this.http.post(this.apiUrl + 'job/AddJob', data);
  }

  getJobList(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl + 'Job/GetJobDetails');
  }

  deleteJobDetails(id:number){
    return this.http.delete<any>(this.apiUrl +'Job/DeleteJob'+id);
     }
}
