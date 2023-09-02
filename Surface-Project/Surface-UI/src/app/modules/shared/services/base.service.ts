import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IBaseListRequest } from '../interfaces/IBaseListRequest';
import { Observable } from 'rxjs';
import { GET_LIST } from 'src/app/constants/config-url.constant';
import { IBaseResponse } from '../interfaces/IBaseResponse';
import { IDropdownResponse } from '../interfaces/IDropdownResponse';
import { IPreserveFilter } from '../interfaces/IPreserveFilter';
import { IBaseListResponse } from '../interfaces/IBaseListResponse';


@Injectable({
  providedIn: 'root'
})
export class BaseService<T> {

  constructor(private http: HttpClient, @Inject("BASE_URL") private url: string) {
  }

  getList(request: IBaseListRequest): Observable<IBaseResponse<IBaseListResponse<T>>> {
    return this.http
      .post<IBaseResponse<IBaseListResponse<T>>> (this.url + GET_LIST, request);
  }

  getById(id: number): Observable<IBaseResponse<T>> {
    return this.http
      .get<IBaseResponse<T>>(`${this.url}/${id}`);
  }

  add(data: T): Observable<IBaseResponse<T>> {
    return this.http
      .post<IBaseResponse<T>>(this.url, data);
  }

  update(id: number, data: T): Observable<IBaseResponse<T>> {
    return this.http
      .put<IBaseResponse<T>>(`${this.url}/${id}`, data);
  }

  delete(id: number): Observable<IBaseResponse<T>> {
    return this.http
      .delete<IBaseResponse<T>>(`${this.url}/${id}`);
  }

  getDropdownList() : Observable<IDropdownResponse> {
    return this.http
      .get<IDropdownResponse>(this.url + GET_LIST);
  }

  //set preserve filter
  setPreserveFilter(filter: IBaseListRequest, sessionKey: string)  : void{
    sessionStorage.setItem(sessionKey, JSON.stringify(filter));
  }

  //get preserve filter
  getPreserveFilter(sessionKey: string): IPreserveFilter | null {
    const pagePreserveJSONString = sessionStorage.getItem(sessionKey);
    const pagePreserve: IPreserveFilter | null = JSON.parse(pagePreserveJSONString ?? 'null') as IPreserveFilter;
    return pagePreserve;
  }  
}