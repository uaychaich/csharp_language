/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-12
*/
public class SampleClass1<T>
{
    //field
    public T _Data1;
    //property
    public T Data1{get=>_Data1;set=>_Data1=value;}
    //method
    public T Method1(T inputdata)=>inputdata;
    //constructor
    public SampleClass1(){}
    public SampleClass1(T inputdata){_Data1 = inputdata;}
}

public class SampleClass2<A,B> where A : class where B : struct 
{
    public A _Data1; public B _Data2;
}

public class SampleClass3{}