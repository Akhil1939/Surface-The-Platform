import { IColumnList, IActionButtonSelection, IWithFilterColumnList } from "../IMatTable.interfaces";

export interface IMatTableInput {
  displayedColumns: string[];
  dataList: any[];
  actionButtons: IActionButtonSelection;
  columnList: IColumnList[];
  withFilterColumnList: IWithFilterColumnList[];
}
