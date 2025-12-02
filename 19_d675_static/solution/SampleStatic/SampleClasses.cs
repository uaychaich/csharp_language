/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-10
*/
public static class Class1
{
    public static int _Data1;
    public static int Data1{get=>_Data1;set=>_Data1=value;}
    public static int Method1()=>Data1;
    static Class1(){_Data1=100;}
}

public class Class2
{
    private int _Data2a;
    private static int _Data2b;
    public int Data2a{get=>_Data2a;set=>_Data2a=value;}
    public int Data2b{get=>_Data2b;set=>_Data2b=value;}
    public static int Data2d{get=>_Data2b;set=>_Data2b=value;}
    public Class2(){_Data2a=100;_Data2b=200;}
}

public class Class3
{
    public int _Data1,_Data2;
    public static Class3 operator + (Class3 left, Class3 right)
    {
        var result = new Class3();
        result._Data1 = left._Data1+right._Data1;
        result._Data2 = left._Data2+right._Data2;
        return result;
    }
    public static Class3 operator + (Class3 left, int right)
    {
        var result = new Class3();
        result._Data1 = left._Data1+right;
        result._Data2 = left._Data2+right;
        return result;
    }
}