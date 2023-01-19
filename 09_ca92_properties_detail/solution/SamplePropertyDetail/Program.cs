/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-19
*/
PeopleClass pc1 = new PeopleClass();
pc1.FirstName="Uaychai";pc1.LastName="Chotjaratwanich";
pc1.MiddleName="uc"; pc1.Income=500;

PeopleClass pc2 = new PeopleClass(){FirstName="Uaychai",LastName="Chotjaratwanich",
                                    MiddleName="uc",Income=500,MiddleName2="aaa"};
Console.WriteLine(pc1.FirstName);
Console.WriteLine(pc1.LastName);
Console.WriteLine(pc1.MiddleName);
Console.WriteLine(pc1.MiddleName2);
Console.WriteLine(pc1.Income);
Console.WriteLine(pc1.FullName);

PeopleStruct ps1 = new PeopleStruct();
ps1.FirstName="Uaychai";ps1.LastName="Chotjaratwanich";
ps1.MiddleName="uc"; ps1.Income=500;

PeopleStruct ps2 = new PeopleStruct(){FirstName="Uaychai",LastName="Chotjaratwanich",
                                      MiddleName="uc",Income=500,MiddleName2="aaa"};
Console.WriteLine(ps1.FirstName);
Console.WriteLine(ps1.LastName);
Console.WriteLine(ps1.MiddleName);
Console.WriteLine(pc1.MiddleName2);
Console.WriteLine(ps1.Income);
Console.WriteLine(ps1.FullName);