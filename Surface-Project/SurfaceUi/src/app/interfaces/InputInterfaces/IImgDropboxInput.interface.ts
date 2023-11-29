import { IStudentProfileMedia } from 'src/app/modules/student/interfaces/istudent-profile-media.model';

export interface IImageDropboxInput {
  label: string;
  imgHeight: string;
  imgWidth: string;
  multiple: boolean;
  imagePaths: string[];
  id?: string;
  media?: IStudentProfileMedia[];
  fileSize?:number
}
