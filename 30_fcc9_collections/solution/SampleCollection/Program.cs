/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-15
*/
using System.Collections;

PeopleClass pc1 = new PeopleClass(){Data1=80};
PeopleStructure ps1 = new PeopleStructure(){Data1=80};

//Array
int[] a1 = new int[2]; a1[0] = 5; a1[1] = 10; 
Console.WriteLine(a1[0]);Console.WriteLine(a1[1]);

//Collection
ArrayList b1 = new ArrayList();
b1.Add(5); b1.Add("Uaychai"); b1.Add(pc1); b1.Add(ps1);
Console.WriteLine(b1[0]);Console.WriteLine(b1[1]);Console.WriteLine(b1[2]);Console.WriteLine(b1[3]);

Queue c1 = new Queue(); 
c1.Enqueue(5); c1.Enqueue("Uaychai"); c1.Enqueue(pc1); c1.Enqueue(ps1);
Console.WriteLine(c1.Dequeue());Console.WriteLine(c1.Dequeue());Console.WriteLine(c1.Dequeue());Console.WriteLine(c1.Dequeue());

Stack d1 = new Stack();
d1.Push(5); d1.Push("Uaychai"); d1.Push(pc1); d1.Push(ps1);
Console.WriteLine(d1.Pop());Console.WriteLine(d1.Pop());Console.WriteLine(d1.Pop());Console.WriteLine(d1.Pop());

Hashtable e1 = new Hashtable();
e1.Add(0,"Uaychai"); e1.Add("a2",pc1); e1.Add(pc1,ps1);
Console.WriteLine(e1[0]);Console.WriteLine(e1["a2"]);Console.WriteLine(e1[pc1]);

//Generic collection
List<int> f1 = new List<int>();
f1.Add(5);f1.Add(8);f1.Add(20);
Console.WriteLine(f1[0]);Console.WriteLine(f1[1]);Console.WriteLine(f1[2]);

Queue<int> g1 = new Queue<int>();
g1.Enqueue(5);g1.Enqueue(8);g1.Enqueue(20);
Console.WriteLine(g1.Dequeue());Console.WriteLine(g1.Dequeue());Console.WriteLine(g1.Dequeue());

Stack<int> h1 = new Stack<int>();
h1.Push(5); h1.Push(8); h1.Push(20);
Console.WriteLine(h1.Pop());Console.WriteLine(h1.Pop());Console.WriteLine(h1.Pop());

Dictionary<int,string> i1 = new Dictionary<int, string>();
i1.Add(0,"Uaychai");i1.Add(10,"Somchai");i1.Add(20,"Somying");
Console.WriteLine(i1[0]);Console.WriteLine(i1[10]);Console.WriteLine(i1[20]);

//Collection with foreach
foreach (var item in f1)
{Console.WriteLine(item);}

foreach (var item in i1)
{Console.WriteLine(item);}

foreach (var item in i1.Keys)
{Console.WriteLine(item);}

foreach (var item in i1.Values)
{Console.WriteLine(item);}