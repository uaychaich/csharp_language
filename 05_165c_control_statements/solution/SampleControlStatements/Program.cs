/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2022-12-31
*/

//if
var a1 = 5;
var a2 = 6;
if (a1 >= 5 && a2 >= 6) {Console.WriteLine("Both true");}

//if...else
var b1 = 5;
var b2 = 6;
if (b1 >= 5 && b2 >= 6) {Console.WriteLine("Both true");}
else{Console.WriteLine("Some true or Both fail");}

//if...else if...else
var c1 = 5;
var c2 = 6;
if (c1 >= 5 && c2 >= 6) {Console.WriteLine("Both true");}
else if (c1 >= 5 || c2 >= 6) {Console.WriteLine("Some true");}
else{Console.WriteLine("Both fail");}

//switch constant
var d1 = 5;
var d2 = 6;
switch (d1)
{
    case 1: Console.WriteLine("One");break;
    case 2: Console.WriteLine("Two");break;
    case 3: Console.WriteLine("Three");break;
    case 4: Console.WriteLine("Four");break;
    case 5: Console.WriteLine("Five");break;
    default: Console.WriteLine("Esle");break;
}

//switch relational
var e1 = 5;
var e2 = 6;
switch (e1)
{
    case >5: Console.WriteLine("More than five");break;
    case 5: Console.WriteLine("Equal five");break;
    case <5: Console.WriteLine("Less than five");break;
    default: Console.WriteLine("Else");break;
}

//switch relational 2
var f1 = 5;
var f2 = 6;
switch (f1)
{
    case >5 or <0: Console.WriteLine("More than five or Less than zero");break;
    case 5 or 6: Console.WriteLine("Equal five or six");break;
    default: Console.WriteLine("Else");break;
}

//for loop
var g1 = 0;
for(g1=0;g1<4;g1++){Console.Write(g1);} Console.WriteLine();

int[] g2 = new int[]{10,20,30};
for(g1=0;g1<=2;g1++){Console.Write(g2[g1]);} Console.WriteLine();

//while loop
var h1 = 0;
while(h1 < 3){Console.Write(h1);h1++;} Console.WriteLine();
h1=0;
int[] h2 = new int[]{10,20,30};
while(h1 < 3){Console.Write(h2[h1]);h1++;} Console.WriteLine();

//for each loop
int[] i2 = new int[]{10,20,30};
foreach(int i1 in i2){Console.Write(i1);}