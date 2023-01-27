/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-02
*/
var varc1=5;
var varc2=8;
SampleClassMethod scm1 = new SampleClassMethod();
scm1.method1(varc1); scm1.method1(varc1,varc2);scm1.method1(input2:varc2,input1:varc1);
scm1.method2(varc1,out varc2);scm1.method2(output1:out varc2,input1:varc1); Console.WriteLine(varc2);
scm1.method3(5,6,7,8,9,10);
var varc3 = scm1.method4(); Console.WriteLine(varc3);
var varc4 = scm1.method5(6,7); Console.WriteLine(varc4);

var vars1=5;
var vars2=8;
SampleStructureMethod ssm1 = new SampleStructureMethod();
ssm1.method1(vars1); ssm1.method1(vars1,vars2);ssm1.method1(input2:vars2,input1:vars1);
ssm1.method2(vars1,out vars2);ssm1.method2(output1:out vars2,input1:vars1); Console.WriteLine(vars2);
ssm1.method3(5,6,7,8,9,10);
var vars3 = ssm1.method4(); Console.WriteLine(vars3);
var vars4 = ssm1.method5(6,7); Console.WriteLine(vars4);

PeopleClass pc1 = new PeopleClass(){FirstName="Uaychai",LastName="Chotjaratwanich",Height=175};
PeopleClass pc2 = new PeopleClass(){FirstName="Somsak",LastName="Kiddee",Height=165};
var resultc = pc1.CompareHeight(pc2); Console.WriteLine(resultc==1?$"{pc1.FirstName} is higher":$"{pc1.FirstName} is lower");

PeopleStructure ps1 = new PeopleStructure(){FirstName="Uaychai",LastName="Chotjaratwanich",Height=175};
PeopleStructure ps2 = new PeopleStructure(){FirstName="Somsak",LastName="Kiddee",Height=165};
var results = ps1.CompareHeight(ps2); Console.WriteLine(results==1?$"{ps1.FirstName} is higher":$"{ps1.FirstName} is lower");
