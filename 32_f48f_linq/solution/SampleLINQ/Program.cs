/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-15
*/

using System.Collections.Generic;
using System.Linq;

PeopleClass pc1 = 
new PeopleClass(){PeopleID=1,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PeopleClass pc2 = 
new PeopleClass(){PeopleID=2,FirstName="Somchai",LastName="Jaiharn",Salary=40000,Birthday=new DateTime(2000,11,05)};
PeopleClass pc3 = 
new PeopleClass(){PeopleID=3,FirstName="Somying",LastName="Kornpanom",Salary=60000,Birthday=new DateTime(2010,2,14)};
PeopleClass pc4 = 
new PeopleClass(){PeopleID=4,FirstName="Pitak",LastName="Woradeth",Salary=30000,Birthday=new DateTime(2009,7,5)};
PeopleClass pc5 = 
new PeopleClass(){PeopleID=5,FirstName="Siwaluk",LastName="Pornsri",Salary=60000,Birthday=new DateTime(2012,12,24)};

PeopleClass[] pcs1 = new PeopleClass[]{pc1,pc2,pc3,pc4,pc5}; 

var query1 = from a in pcs1 where a.Salary >= 50000 orderby a.LastName, a.FirstName select a;
foreach (var item in query1)
{Console.WriteLine($"{item.PeopleID} {item.FirstName} {item.LastName} {item.Salary} {item.Birthday}");}

var query2 = pcs1.Where(x=>x.Salary>=50000).OrderBy(x=>x.LastName).ThenBy(x=>x.FirstName);
foreach (var item in query2)
{Console.WriteLine($"{item.PeopleID} {item.FirstName} {item.LastName} {item.Salary} {item.Birthday}");}


PeopleStructure ps1 = 
new PeopleStructure(){PeopleID=1,FirstName="Uaychai",LastName="Chotjaratwanich",Salary=50000,Birthday=new DateTime(1999,5,23)};
PeopleStructure ps2 = 
new PeopleStructure(){PeopleID=2,FirstName="Somchai",LastName="Jaiharn",Salary=40000,Birthday=new DateTime(2000,11,05)};
PeopleStructure ps3 = 
new PeopleStructure(){PeopleID=3,FirstName="Somying",LastName="Kornpanom",Salary=60000,Birthday=new DateTime(2010,2,14)};
PeopleStructure ps4 = 
new PeopleStructure(){PeopleID=4,FirstName="Pitak",LastName="Woradeth",Salary=30000,Birthday=new DateTime(2009,7,5)};
PeopleStructure ps5 = 
new PeopleStructure(){PeopleID=5,FirstName="Siwaluk",LastName="Pornsri",Salary=60000,Birthday=new DateTime(2012,12,24)};

PeopleStructure[] pss1 = new PeopleStructure[]{ps1,ps2,ps3,ps4,ps5}; 

var query3 = from a in pss1 where a.Salary >= 50000 orderby a.LastName, a.FirstName select a;
foreach (var item in query3)
{Console.WriteLine($"{item.PeopleID} {item.FirstName} {item.LastName} {item.Salary} {item.Birthday}");}

var query4 = pss1.Where(x=>x.Salary>=50000).OrderBy(x=>x.LastName).ThenBy(x=>x.FirstName);
foreach (var item in query4)
{Console.WriteLine($"{item.PeopleID} {item.FirstName} {item.LastName} {item.Salary} {item.Birthday}");}