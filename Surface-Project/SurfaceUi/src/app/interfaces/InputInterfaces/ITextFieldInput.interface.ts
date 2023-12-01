export interface IInputField {
  controlName: string;
  label: string;
  placeholder: string;
  type: string;
  disabled: boolean;
  formGroupName?: string;
  formArrayName?: string;
  value?: string;
}
