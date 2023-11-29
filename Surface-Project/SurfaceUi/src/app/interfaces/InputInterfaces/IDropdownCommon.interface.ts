import { IDropdownItem } from '../IDropdownItem.interface';

export interface IDropdownInput {
  title: string;
  placeholder: string;
  controlName: string;
  isMultiple: boolean;
  optionsList: IDropdownItem[];
  formGroupName?: string;
}
