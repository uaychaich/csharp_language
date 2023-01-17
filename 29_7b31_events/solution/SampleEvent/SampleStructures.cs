/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-12
*/
public struct PeopleStructure
{
    //field
    private DateTime _Birthday;
    //property
    public DateTime Birthday1 {get=>_Birthday;set=>_Birthday = value < DateTime.Now?value:throw new System.Exception("Birthday MUST be less Now");}
    //events
    public event Action<DateTime> BirthdayNotCorrect;
    //property
    public DateTime Birthday2 
    {   get=>_Birthday;
        set
        {
            if(value< DateTime.Now){_Birthday=value;}else{_Birthday=DateTime.MinValue;BirthdayNotCorrect(value);}                        
        }
    }
}