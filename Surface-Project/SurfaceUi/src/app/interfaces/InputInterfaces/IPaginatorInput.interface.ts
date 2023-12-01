import { EventEmitter } from "@angular/core";
import { IPaginatorEvent } from "../IPaginatorEvent.interface";

export interface IPaginatorInput{
  length: number;
  pageSize: number;
  pageIndex: number;
  pageSizeOptions: number[];
}
