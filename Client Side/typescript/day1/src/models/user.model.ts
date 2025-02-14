export interface IUser {
  id: number | string;
  email?: string;
  name: string;
  address?: {
    streetName: string;
    posterCode: string | number;
  };
}
