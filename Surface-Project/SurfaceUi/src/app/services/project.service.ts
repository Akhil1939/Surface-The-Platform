import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BASE_ROUTE, CREATE_PROJECT } from '../constants/routeConst';
import { iCreateProject } from '../interfaces/project_interfaces/iCreateProject.interface';
import { Observable } from 'rxjs';
import { CommonHttpResponse } from '../interfaces/httpresponse.interface';

@Injectable({
  providedIn: 'root'
})

export class ProjectService {

  constructor(private httpClient: HttpClient) { }
  //create project
  create(data: iCreateProject):Observable<CommonHttpResponse<number>> {
    return this.httpClient.post<CommonHttpResponse<number>>(BASE_ROUTE + CREATE_PROJECT, data);
  }
}
