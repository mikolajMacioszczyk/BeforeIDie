export interface IGoal{
  id: number,
  title: string,
  description: string,
  localization: string,
  imgUrl: string
}

export class Goal implements IGoal{
  description: string;
  id: number;
  imgUrl: string;
  localization: string;
  title: string;
}
