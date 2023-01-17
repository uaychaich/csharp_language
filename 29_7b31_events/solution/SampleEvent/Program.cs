/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-12
*/

PeopleClass pc1 = new PeopleClass();
pc1.BirthdayNotCorrect += (a)=>throw new System.Exception($"{a} is not less than now");
pc1.Birthday2 = new DateTime(1999,5,23);
Console.WriteLine(pc1.Birthday2);

PeopleClass pc2 = new PeopleClass();
pc2.BirthdayNotCorrect += (a)=>Console.WriteLine($"{a} is not in Birthday");
pc2.Birthday2 = new DateTime(1999,5,23);
Console.WriteLine(pc2.Birthday2);

PeopleStructure ps1 = new PeopleStructure();
ps1.BirthdayNotCorrect += (a)=>throw new System.Exception($"{a} is not less than now");
ps1.Birthday2 = new DateTime(1999,5,23);
Console.WriteLine(ps1.Birthday2);

PeopleStructure ps2 = new PeopleStructure();
ps2.BirthdayNotCorrect += (a)=>Console.WriteLine($"{a} is not in Birthday");
ps2.Birthday2 = new DateTime(1999,5,23);
Console.WriteLine(ps2.Birthday2);