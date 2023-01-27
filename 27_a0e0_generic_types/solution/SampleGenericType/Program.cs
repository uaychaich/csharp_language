/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-12
*/
SampleClass1<int> sc11 = new SampleClass1<int>();
sc11._Data1 = 20; sc11.Data1 = 30; Console.WriteLine($"{sc11.Data1} | {sc11.Method1(50)}");

SampleClass1<string> sc12 = new SampleClass1<string>();
sc12._Data1 = "Uaychai"; sc12.Data1 = "Chotjaratwanich"; Console.WriteLine($"{sc12.Data1} | {sc12.Method1("Kiki")}");

SampleClass2<string,DateTime> sc21 = new SampleClass2<string, DateTime>();
sc21._Data1 = "Uaychai"; sc21._Data2 = new DateTime(1999,5,23); Console.WriteLine($"{sc21._Data1} | {sc21._Data2}");

SampleClass2<SampleClass3,SampleStructure3> sc22 = new SampleClass2<SampleClass3, SampleStructure3>();

SampleStructure1<int> ss11 = new SampleStructure1<int>();
ss11._Data1 = 20; ss11.Data1 = 30; Console.WriteLine($"{ss11.Data1} | {ss11.Method1(50)}");

SampleStructure1<string> ss12 = new SampleStructure1<string>();
ss12._Data1 = "Uaychai"; ss12.Data1 = "Chotjaratwanich"; Console.WriteLine($"{ss12.Data1} | {ss12.Method1("Kiki")}");

SampleStructure2<string,DateTime> ss21 = new SampleStructure2<string, DateTime>();
ss21._Data1 = "Uaychai"; ss21._Data2 = new DateTime(1999,5,23); Console.WriteLine($"{ss21._Data1} | {ss21._Data2}");

SampleStructure2<SampleClass3,SampleStructure3> ss22 = new SampleStructure2<SampleClass3, SampleStructure3>();
