export interface IAlmUser {
  AlmUserId: string;
  FieldId: string;
  GraduateYear: string;
  ProStatus: string;
  CompanyId: string;
  Position: string;
  Contrat: string;
  Companylocalisation: string;
  UserName: string;
  Email: string;
  NormalizedEmail: string;
  PasswordHash: string;
  Firtname: string;
  Lastname: string;
  Gender: string;
  PhoneNumber: string;
  WhatsappNumber: string;
  Dob: string;
  UserLocation: string;
  ImageDirectory: string;
}

export enum ProStatus{
  Employe,
  Freelance,
  Stage
}

export enum Contrat{
  CDI,
  CDD
}
