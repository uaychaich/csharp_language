/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-08
*/
SampleClass1 sc1 = new SampleClass1(); 
var data1 = sc1.Method1(6,2); Console.WriteLine(data1);

SampleClass1_1 sc11 = new SampleClass1_1(); 
var data11 = sc11.Method1(6,2); Console.WriteLine(data11);

SampleClass2_1 sc21 = new SampleClass2_1();
var data21 = sc21.Method1(6,2); Console.WriteLine($"{data21} {sc21.Prop1}");