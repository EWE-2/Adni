export interface AlmUser {
  userName: string;
  email: string;
  normalizedEmail: string;
  passwordHash: string;
  firtname: string;
  lastname: string;
  gender: string;
  fieldId: string;
  graduateYear: string;
  phoneNumber: string;
  dob: string;
  proStatus: string;
  companyId: string;
  position: string
}

enum ProStatus{
  Employe,
  Freelance,
  Stage
}

enum Contrat{
  CDI,
  CDD
}
