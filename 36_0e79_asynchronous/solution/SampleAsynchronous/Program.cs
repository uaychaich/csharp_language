/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-21
*/
using System.Threading.Tasks;

int a1 = HelperClass.SyncMethod1();
for(int i=0;i<10;i++){System.Threading.Thread.Sleep(1000);Console.WriteLine("Do Something");}
Console.WriteLine(a1);


Task<int> b1 = HelperClass.AsyncMethod1();
for(int i=0;i<10;i++){System.Threading.Thread.Sleep(1000);Console.WriteLine($"Do Something | {b1.Status}");}
int b11 = await b1;Console.WriteLine(b11);


int c1 = HelperStructure.SyncMethod1();
for(int i=0;i<10;i++){System.Threading.Thread.Sleep(1000);Console.WriteLine("Do Something");}
Console.WriteLine(c1);


Task<int> d1 = HelperStructure.AsyncMethod1();
for(int i=0;i<10;i++){System.Threading.Thread.Sleep(1000);Console.WriteLine($"Do Something | {d1.Status}");}
int d11 = await d1;Console.WriteLine(d11);