/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-19
*/
public class SomethingData
{
    public string FirstName{get;set;}
    public double Salary{get;set;}
    public DateTime Birthday{get;set;}
}
public class DataHelper
{
    public static SomethingData getData1()
    {
        SomethingData result = new SomethingData(){FirstName="Uaychai",Salary=50000,Birthday=new DateTime(1999,5,23)};
        return result;
    }
    public static (string,double,DateTime) getData2()
    {
        (string,double,DateTime) result = ("Uaychai",50000,new DateTime(1999,5,23));
        return result;
    }
}