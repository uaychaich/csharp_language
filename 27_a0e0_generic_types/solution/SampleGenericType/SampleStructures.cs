/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-12
*/
public struct SampleStructure1<T>
{
    //field
    public T _Data1;
    //property
    public T Data1{get=>_Data1;set=>_Data1=value;}
    //method
    public T Method1(T inputdata)=>inputdata;
    //constructor
    public SampleStructure1(){}
    public SampleStructure1(T inputdata){_Data1 = inputdata;}
}

public struct SampleStructure2<A,B> where A : class where B : struct 
{
    public A _Data1; public B _Data2;
}

public struct SampleStructure3{}