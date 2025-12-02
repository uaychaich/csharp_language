/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-20
*/

(bool,System.Collections.Generic.List<string>) result1, result2;

PersonClass pc1 = new PersonClass(){FirstName="Uay",LastName="Chot"};
result1 = CheckObject<PersonClass>.CheckData(pc1);
Console.WriteLine($"IsValid: {result1.Item1}");
foreach (var item in result1.Item2){Console.WriteLine(item);}

PersonStructure ps1 = new PersonStructure(){FirstName="Uay",LastName="Chot"};
result2 = CheckObject<PersonStructure>.CheckData(ps1);
Console.WriteLine($"IsValid: {result2.Item1}");
foreach (var item in result2.Item2){Console.WriteLine(item);}