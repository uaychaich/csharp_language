/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-08
*/
public struct Structure1
{
    //field
    public int _Data1;
    //property
    public int Data1{set=>_Data1=value; get=>_Data1;}
    //method
    public int Method1()=>Data1;
    //constructor
    public Structure1(){Data1=100;}
    public Structure1(int inputdata1){Data1=inputdata1;}
}