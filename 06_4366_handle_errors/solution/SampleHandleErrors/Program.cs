/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-02
*/
//Sample 1
int birthyear1 = 1980; //<--This value is send from another program
int presentyear1 = 2023;
int age1 = presentyear1 - birthyear1;
Console.WriteLine(age1);

//throw
int birthyear2 = 1999; //<--This value is send from another program
if(birthyear2 <= 1000 || birthyear2 >= 9999 )
{throw new ArgumentException("Birthyear is not right");}
int presentyear2 = 2023;
int age2 = presentyear2 - birthyear2;
Console.WriteLine(age2);


//Sample 2
Console.Write("What is your birth year?: ");
int birthyear3 = int.Parse(Console.ReadLine());
Console.WriteLine(birthyear3);

//try...catch
Console.Write("What is your birth year?: ");
try{
    int birthyear4 = int.Parse(Console.ReadLine());
    Console.WriteLine(birthyear4);
}catch(OverflowException ex){
    Console.WriteLine("Birthyear is int");
}
catch(FormatException ex){
    Console.WriteLine("Birthyear MUST be numeric");
}
catch(Exception ex){
    Console.WriteLine("Something went wrong");
}