/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-10
*/
public struct Structure2
{
    private int _Data2a;
    private static int _Data2b;
    public int Data2a{get=>_Data2a;set=>_Data2a=value;}
    public int Data2b{get=>_Data2b;set=>_Data2b=value;}
    public static int Data2d{get=>_Data2b;set=>_Data2b=value;}
    public Structure2(){_Data2a=100;_Data2b=200;}
}

public struct Structure3
{
    public int _Data1,_Data2;
    public static Structure3 operator + (Structure3 left, Structure3 right)
    {
        var result = new Structure3();
        result._Data1 = left._Data1+right._Data1;
        result._Data2 = left._Data2+right._Data2;
        return result;
    }
    public static Structure3 operator + (Structure3 left, int right)
    {
        var result = new Structure3();
        result._Data1 = left._Data1+right;
        result._Data2 = left._Data2+right;
        return result;
    }
}