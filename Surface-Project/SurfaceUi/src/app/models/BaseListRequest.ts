import { IBaseListRequest } from "../interfaces/IBaseListRequest";

export class BaseListRequest implements IBaseListRequest {
    pageIndex : number;
    pageSize : number;
    sortOrder : "ascending" | "descending";
    sortColumn: string;
    searchQuery: string | null;

   constructor(options?: Partial<IBaseListRequest>) {
    // Set default values if options are not provided
    this.pageIndex = 1;
    this.pageSize = 10;
    this.sortOrder = "descending";
    this.sortColumn = "id";
    this.searchQuery = null;

    // If options are provided, overwrite the default values with the provided ones
    if (options) 
      Object.assign(this, options);
    }
}