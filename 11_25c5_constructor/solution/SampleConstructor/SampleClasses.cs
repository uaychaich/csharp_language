/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-11
*/
public class SampleClass
{
    //field
    public int _Data1;
    public readonly int _Data2;
    //property
    public int Data1{set=>_Data1=value; get=>_Data1;}
    //method
    public void Dosomething(){}
    //constructor
    public SampleClass(){Data1=500;_Data2=700;Dosomething();}
    public SampleClass(int inputdata, int inputdata2){Data1=inputdata;_Data2=inputdata2;Dosomething();}
}

public class PeopleClass
{
    //field
    public string _FirstName="", _LastName="";
    public readonly int _PeopleID;
    //property
    public string FirstName{set=>_FirstName = value; get=>_FirstName;}
    public string LastName{set=>_LastName = value;get=>_LastName;}
    //method
    public void WriteLog(string log){/*Write log in database*/}
    //constructor
    public PeopleClass(){_FirstName="Jon";_LastName="Dow";_PeopleID=0;WriteLog("Jon Dow is created");}
    public PeopleClass(string inputFirstName, string inputLastName, int inputPeopleID)
    {FirstName=inputFirstName;LastName=inputLastName;_PeopleID=inputPeopleID;WriteLog($"{FirstName} {LastName} is created");}
}