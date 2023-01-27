/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-11
*/
SampleClass sc1 = new SampleClass();Console.WriteLine($"{sc1.Data1} {sc1._Data2}");
SampleClass sc2 = new SampleClass(700,1000);Console.WriteLine($"{sc2.Data1} {sc2._Data2}"); 

SampleStructure ss1 = new SampleStructure();Console.WriteLine($"{ss1.Data1} {ss1._Data2}");
SampleStructure ss2 = new SampleStructure(700,1000);Console.WriteLine($"{ss2.Data1} {ss2._Data2}");

PeopleClass pc1 = new PeopleClass();Console.WriteLine($"{pc1.FirstName} {pc1.LastName} {pc1._PeopleID}");
PeopleClass pc2 = new PeopleClass("Uaychai","Chotjaratwanich",220);Console.WriteLine($"{pc2.FirstName} {pc2.LastName} {pc2._PeopleID}");

PeopleStructure ps1 = new PeopleStructure();Console.WriteLine($"{ps1.FirstName} {ps1.LastName} {ps1._PeopleID}");
PeopleStructure ps2 = new PeopleStructure("Uaychai","Chotjaratwanich",220);Console.WriteLine($"{ps2.FirstName} {ps2.LastName} {ps2._PeopleID}");