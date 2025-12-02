/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-11
*/
PeopleClass pc1 = new PeopleClass();
pc1.FullName="Uaychai Chotjaratwanich";pc1.Income=100000;
pc1.Gender=GenderEnum.Male;pc1.MaritalStatus=MaritalStatusEnum.Single;
Console.WriteLine($"{pc1.FullName} {pc1.Income} {pc1.Gender} {pc1.MaritalStatus}");

PeopleStructure ps1 = new PeopleStructure();
ps1.FullName="Uaychai Chotjaratwanich";ps1.Income=100000;
ps1.Gender=GenderEnum.Male;ps1.MaritalStatus=MaritalStatusEnum.Single;
Console.WriteLine($"{ps1.FullName} {ps1.Income} {ps1.Gender} {ps1.MaritalStatus}");