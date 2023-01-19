/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-19
*/

PersonClass pc1 = new PersonClass(){PersonID=5,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PersonClass pc2 = new PersonClass(){PersonID=5,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PersonClass pc3 = pc1;
Console.WriteLine($"{pc1==pc2} | {pc1==pc3} | {object.Equals(pc1,pc2)} | {object.Equals(pc1,pc3)} | {pc1}");

PersonStructure ps1 = new PersonStructure(){PersonID=5,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PersonStructure ps2 = new PersonStructure(){PersonID=5,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PersonStructure ps3 = ps1;
Console.WriteLine($"{object.Equals(ps1,ps2)} | {object.Equals(ps1,ps3)} | {ps1}");

PersonRecord pr1 = new PersonRecord(){PersonID=5,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PersonRecord pr2 = new PersonRecord(){PersonID=5,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PersonRecord pr3 = pr1;
Console.WriteLine($"{pr1==pr2} | {pr1==pr3} | {object.Equals(pr1,pr2)} | {object.Equals(pr1,pr3)} | {pr1}");

PersonRecordStructure prs1 = new PersonRecordStructure(){PersonID=5,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PersonRecordStructure prs2 = new PersonRecordStructure(){PersonID=5,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PersonRecordStructure prs3 = prs1;
Console.WriteLine($"{prs1==prs2} | {prs1==prs3} | {object.Equals(prs1,prs2)} | {object.Equals(prs1,prs3)} | {prs1}");