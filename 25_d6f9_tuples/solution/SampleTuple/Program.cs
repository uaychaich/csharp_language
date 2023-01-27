/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-19
*/
(string,double,DateTime) a1;
a1=("Uaychai",50000,new DateTime(1999,5,23));
var a2 = a1;
a1.Item1="Yoda";
Console.WriteLine($"{a1.Item1} {a1.Item2} {a1.Item3}");
Console.WriteLine($"{a2.Item1} {a2.Item2} {a2.Item3}");

Console.WriteLine($"{DataHelper.getData1().FirstName} | {DataHelper.getData2().Item1}");