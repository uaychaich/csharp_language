/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-10
*/
Console.WriteLine($"{Class1._Data1} {Class1.Data1} {Class1.Method1()}");

Class2 c2 = new Class2();
Console.WriteLine($"{c2.Data2a} {c2.Data2b} {Class2.Data2d}");

Structure2 s2 = new Structure2();
Console.WriteLine($"{s2.Data2a} {s2.Data2b} {Structure2.Data2d}");

Class3 c31 = new Class3(){_Data1=20,_Data2=30};
Class3 c32 = new Class3(){_Data1=50,_Data2=60};
Class3 c3r1 = c31+c32; Console.WriteLine($"{c3r1._Data1} {c3r1._Data2}");
Class3 c3r2 = c31+40; Console.WriteLine($"{c3r2._Data1} {c3r2._Data2}");

Structure3 s31 = new Structure3(){_Data1=20,_Data2=30};
Structure3 s32 = new Structure3(){_Data1=50,_Data2=60};
Structure3 s3r1 = s31+s32; Console.WriteLine($"{s3r1._Data1} {s3r1._Data2}");
Structure3 s3r2 = s31+40; Console.WriteLine($"{s3r2._Data1} {s3r2._Data2}");