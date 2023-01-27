/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-02
*/

//No Code Filter
RecClass1 rc11 = new RecClass1();
RecStruct1 rs11 = new RecStruct1();
rc11._Width=20;rc11._Height=30;
rs11._Width=20;rs11._Height=30;

//Use Property
RecClass2 rc21 = new RecClass2();
RecStruct2 rs21 = new RecStruct2();
rc21.Width=20;Console.WriteLine(rc21.Width);
rs21.Width=20;Console.WriteLine(rs21.Width);

//Use Method
rc21.setHeight(30);Console.WriteLine(rc21.getHeight());
rs21.setHeight(30);Console.WriteLine(rs21.getHeight());