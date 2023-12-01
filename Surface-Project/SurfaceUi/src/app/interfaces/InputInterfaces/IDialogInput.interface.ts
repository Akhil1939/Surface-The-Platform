import { FormControl } from '@angular/forms';
import { IButton } from '../IButton.interface';
import { ITextFieldInput } from './iInputField';

export interface IDialogInput{
    title : string;
    message : string;
    falseBtnProps ?: IButton;
    trueBtnProps : IButton;
}
