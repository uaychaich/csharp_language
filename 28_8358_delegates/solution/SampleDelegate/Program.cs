/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-12
*/

SampleClass1 sc11 = new SampleClass1();
SampleStructure1 ss11 = new SampleStructure1();

Delegate1 d11;
d11 = sc11.Method1; Console.WriteLine(d11(5,2));
d11 = sc11.Method2; Console.WriteLine(d11(5,2));
d11 = SampleClass1.Method5; Console.WriteLine(d11(5,2));
d11 = ss11.Method1; Console.WriteLine(d11(5,2));
d11 = ss11.Method2; Console.WriteLine(d11(5,2));
d11 = SampleStructure1.Method5; Console.WriteLine(d11(5,2));

Func<int,int,int> d12;
d12 = sc11.Method1; Console.WriteLine(d12(5,2));
d12 = sc11.Method2; Console.WriteLine(d12(5,2));
d12 = SampleClass1.Method5; Console.WriteLine(d12(5,2));
d12 = ss11.Method1; Console.WriteLine(d12(5,2));
d12 = ss11.Method2; Console.WriteLine(d12(5,2));
d12 = SampleStructure1.Method5; Console.WriteLine(d12(5,2));

d11 = (int a,int b)=>{return a+b;}; Console.WriteLine(d11(5,2));
d11 = (a,b)=>{return a*b;}; Console.WriteLine(d11(5,2));
d11 = (a,b)=>a-b; Console.WriteLine(d11(5,2));

d12 = (int a,int b)=>{return a+b;}; Console.WriteLine(d12(5,2));
d12 = (a,b)=>{return a*b;}; Console.WriteLine(d12(5,2));
d12 = (a,b)=>a-b; Console.WriteLine(d12(5,2));

Action<int> dz;
dz = Console.WriteLine; dz(9);

PeopleClass pc1 = new PeopleClass(){FirstName="Uaychai",LastName="Chotjaratwanich",MiddleName="Yoda"};
Console.WriteLine(pc1.getCustomFullName((a,b,c)=>$"{a} {b}"));
Console.WriteLine(pc1.getCustomFullName((a,b,c)=>$"{a} \"{c}\" {b}"));

PeopleStructure ps1 = new PeopleStructure(){FirstName="Uaychai",LastName="Chotjaratwanich",MiddleName="Yoda"};
Console.WriteLine(ps1.getCustomFullName((a,b,c)=>$"{a} {b}"));
Console.WriteLine(ps1.getCustomFullName((a,b,c)=>$"{a} \"{c}\" {b}"));