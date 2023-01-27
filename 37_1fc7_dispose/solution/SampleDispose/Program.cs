/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-22
    https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/finalizers
*/
using (BaseClassWithFinalizer a1 = new BaseClassWithFinalizer())
{}

BaseClassWithFinalizer a2 = new BaseClassWithFinalizer();
a2.Dispose();

BaseClassWithFinalizer a3 = new BaseClassWithFinalizer();
a3=null;
System.GC.Collect();
