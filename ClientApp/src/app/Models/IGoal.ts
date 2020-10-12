export interface IGoal{
  id: number,
  title: string,
  description: string,
  localization: string,
  imgUrl: string
  status: string;
  dateOfRealization: Date;
  rating: number;
  feelings: string;
}

export class Goal implements IGoal{
  description: string;
  id: number;
  imgUrl: string;
  localization: string;
  title: string;
  status: string;
  dateOfRealization: Date;
  rating: number;
  feelings: string;
}
