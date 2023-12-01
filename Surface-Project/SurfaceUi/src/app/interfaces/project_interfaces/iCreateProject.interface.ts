export interface iCreateProject {
    name: string;
    description: string;
    startDate?: Date;
    endDate?: Date;
    repoLink?: string;
    budget?: number;
    teams?: string[];
  }
  
  // Example usage:
  export const newProject: iCreateProject = {
    name: "",
    description: "",
  };
  