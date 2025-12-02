/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-12
*/
public class SampleStructure1
{
    public int Method1(int input1, int input2){return input1 + input2;}
    public int Method2(int input1, int input2){return input1 - input2;}
    public int Method3(int input1, int input2){return input1 * input2;}
    public string Method4(int input1, int input2){return input1.ToString() + input2.ToString();}
    public static int Method5(int input1, int input2){return input1 + input2;}
}

public struct PeopleStructure
{
    //field
    private string _FirstName,_LastName,_MiddleName;
    //property
    public string FirstName{get=>_FirstName;set=>_FirstName=value;}
    public string LastName{get=>_LastName;set=>_LastName=value;}
    public string MiddleName{get=>_MiddleName;set=>_MiddleName=value;}
    //method
    public string getCustomFullName(Func<string,string,string,string> ProcessFullName)
    {
        return ProcessFullName(FirstName, LastName, MiddleName);
    }
}