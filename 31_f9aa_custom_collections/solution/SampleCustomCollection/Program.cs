/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-15
*/

StudentClass sc1 = new StudentClass(){FirstName="Uaychai",LastName="Chotjaratwanich"};
StudentClass sc2 = new StudentClass(){FirstName="Somchai",LastName="Jaiharn"};
StudentClass sc3 = new StudentClass(){FirstName="Somying",LastName="kiki"};
StudentClass[] scs = new StudentClass[]{sc1,sc2,sc3};

ManyStudentClass msc = new ManyStudentClass(scs);

foreach(var item in msc)
{
    Console.WriteLine($"{item.FirstName} | {item.LastName}");
}

StudentStructure ss1 = new StudentStructure(){FirstName="Uaychai",LastName="Chotjaratwanich"};
StudentStructure ss2 = new StudentStructure(){FirstName="Somchai",LastName="Jaiharn"};
StudentStructure ss3 = new StudentStructure(){FirstName="Somying",LastName="kiki"};
StudentStructure[] sss = new StudentStructure[]{ss1,ss2,ss3};

ManyStudentStructure mss = new ManyStudentStructure(sss);

foreach(var item in mss)
{
    Console.WriteLine($"{item.FirstName} | {item.LastName}");
}