/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-20
*/

(bool,System.Collections.Generic.List<string>) result;

PersonClass pc1 = new PersonClass(){FirstName="Uay",LastName="Chot"};
result = CheckObject<PersonClass>.CheckData(pc1);
Console.WriteLine($"IsValid: {result.Item1}");
foreach (var item in result.Item2){Console.WriteLine(item);}
