/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-02
*/
using System;

public struct RecStruct1
{
    //field
    public double _Width,_Height;
}

public struct RecStruct2
{
    //field
    public double _Width,_Height;
    //property
    public double Width
    {
        set{_Width = value>=0?value:throw new ArgumentException("Width MUST be more than zero");}
        get{return _Width;}
    }
    //method
    public void setHeight(double inputHeight)
    {_Height = inputHeight>=0?inputHeight:throw new ArgumentException("Height MUST be more than zero");}
    public double getHeight(){return _Height;}
}