/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-11
*/

DateTime dt1 = new DateTime(1999,5,23,14,55,33);
DateTime dt2 = dt1.Date;
DateTime dt3 = DateTime.Now;
DateTime dt4 = dt1.AddHours(55);
Console.WriteLine(dt1);
Console.WriteLine(dt2);
Console.WriteLine(dt3);
Console.WriteLine(dt4);
Console.WriteLine(dt1.ToShortDateString());
Console.WriteLine(dt1.ToLongDateString());
DateTime dt5;
bool issuccess = DateTime.TryParse("Uaychai",out dt5);
Console.WriteLine($"{issuccess} | {dt5}");

Console.WriteLine("Uaychai");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Uaychai");
Console.Clear();

