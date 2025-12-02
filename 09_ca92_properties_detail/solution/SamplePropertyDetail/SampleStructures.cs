/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-19
*/
using System;
public struct PeopleStruct
{
    //field
    public string _FirstName, _LastName, _MiddleName, _MiddleName2;
    public double _Income;

    //property
    public string FirstName
    {
        set{_FirstName = value;}
        get{return _FirstName;}
    }
    public string LastName{get;set;}
    public string MiddleName{set=>_MiddleName=value; get=>_MiddleName;}
    public string MiddleName2{init=>_MiddleName2=value; get=>_MiddleName2;}
    public double Income{
        set=>_Income=value>=0?value:throw new ArgumentException("Income MUST be more than zero"); 
        get=>_Income;
    }
    public string FullName{
        get=> $"{FirstName} {MiddleName} {LastName}";
    }
}