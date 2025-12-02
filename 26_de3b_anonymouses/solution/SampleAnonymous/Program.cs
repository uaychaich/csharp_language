/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-19
*/

var a1 = new {FirstName="Uaychai",Salary=50000,Birthday=new DateTime(1999,5,23)};
var a2 = a1;
Console.WriteLine($"{a1.FirstName} {a1.Salary} {a1.Birthday}");
Console.WriteLine($"{a2.FirstName} {a2.Salary} {a2.Birthday}");