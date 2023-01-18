/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-18
*/

public record PersonRecord
{
    private int _PersonID;
    private string _FirstName, _LastName;
    private double _Salary;
    private DateTime _Birthday;
    public int PersonID{get=>_PersonID;set=>_PersonID=value;}
    public string FirstName{get=>_FirstName;set=>_FirstName=value;}
    public string LastName{get=>_LastName;set=>_LastName=value;}
    public double Salary{get=>_Salary;set=>_Salary=value;}
    public DateTime Birthday{get=>_Birthday;set=>_Birthday=value;}
}