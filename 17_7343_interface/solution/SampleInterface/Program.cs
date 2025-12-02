/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-09
*/
Class1 c11 = new Class1();c11.Data=50;
Class1 c12 = new Class1();c12.Data=60;

Class2 c21 = new Class2();c21.Data=70;
Class2 c22 = new Class2();c22.Data=80;

Structure1 s11 = new Structure1();s11.Data=100;
Structure1 s12 = new Structure1();s12.Data=200;

Structure2 s21 = new Structure2();s21.Data=300;
Structure2 s22 = new Structure2();s22.Data=400;

Interface1 i11; 
i11 = c11; Console.WriteLine(i11.ProcessData(7));
i11 = c12; Console.WriteLine(i11.ProcessData(8));
i11 = c21; Console.WriteLine(i11.ProcessData(9));
i11 = c22; Console.WriteLine(i11.ProcessData(10));
i11 = s11; Console.WriteLine(i11.ProcessData(21));
i11 = s12; Console.WriteLine(i11.ProcessData(22));
i11 = s21; Console.WriteLine(i11.ProcessData(23));
i11 = s22; Console.WriteLine(i11.ProcessData(24));
