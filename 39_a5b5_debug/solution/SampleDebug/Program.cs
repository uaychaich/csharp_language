/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-27
*/
using System.Diagnostics;

Console.WriteLine("Uaychai is here");
int a = 5; Debug.WriteLine($"Debug a:{a}");
Console.WriteLine(a);
Debug.WriteLine("Begin Loop");Debug.Indent();
for(a=0;a<5;a++)
{
    Console.WriteLine(a);
    Debug.WriteLineIf(a==2,$"Debug a:{a}");
}
Debug.Unindent();
Debug.WriteLine("End Loop");