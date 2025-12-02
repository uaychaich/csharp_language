/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-20
*/
[Author("Uaychai",Version ="1.0",ModifiedDate ="2023-01-19")]
[Author("Uaychai",Version ="1.1",ModifiedDate ="2023-01-20")]
public class PersonClass
{
    //field
    private string _FirstName,_LastName;
    //property
    [Author("Yoda",Version ="1.0",ModifiedDate ="2023-01-19")]
    public string FirstName{get=>_FirstName;set=>_FirstName=value;}
    [Author("Uaychai",Version ="1.0",ModifiedDate ="2023-01-19")]
    public string LastName{get=>_LastName;set=>_LastName=value;}

    //method
    [Author("Uaychai",Version ="1.0",ModifiedDate ="2023-01-19")]
    public string getFullName()=>$"{_FirstName} {_LastName}";

    //constructor
    [Author("Uaychai",Version ="1.0",ModifiedDate ="2023-01-19")]
    public PersonClass(){_FirstName="";_LastName="";}
    [Author("Uaychai",Version ="1.0",ModifiedDate ="2023-01-19")]
    public PersonClass(string fn,string ln){FirstName=fn;LastName=ln;}

    //event
    [Author("Uaychai",Version ="1.0",ModifiedDate ="2023-01-19")]
    public event Action<int> Surprise;
}