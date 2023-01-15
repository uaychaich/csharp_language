/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-15
*/
using System.Collections;

PeopleClass pc1 = new PeopleClass(){Data1=80};
PeopleStructure ps1 = new PeopleStructure(){Data1=80};


int[] a1 = new int[2]; a1[0] = 5; a1[1] = 10; 
foreach (var item in a1)
{   Console.WriteLine(item);}

ArrayList b1 = new ArrayList();
b1.Add(5); b1.Add("Uaychai"); b1.Add(pc1); b1.Add(ps1);
foreach (var item in b1)
{   Console.WriteLine(item);}

Queue c1 = new Queue(); 
c1.Enqueue(5); c1.Enqueue("Uaychai"); c1.Enqueue(pc1); c1.Enqueue(ps1);
