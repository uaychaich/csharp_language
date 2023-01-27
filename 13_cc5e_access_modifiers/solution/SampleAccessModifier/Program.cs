/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-08
*/
SampleClass1 sc1 = new SampleClass1();
Console.WriteLine($"{sc1._Data1} {sc1.Data1} {sc1.getData1()}");

SampleClass1_1 sc11 = new SampleClass1_1();
Console.WriteLine($"{sc11._Data1} {sc11.Data1} {sc11.getData1()}");

SampleClass1_2 sc12 = new SampleClass1_2(100,300);
Console.WriteLine($"{sc12._Data1} {sc12.Data1} {sc12.getData1()}");

SampleStruct1 ss1 = new SampleStruct1();
Console.WriteLine($"{ss1._Data1} {ss1.Data1} {ss1.getData1()}");