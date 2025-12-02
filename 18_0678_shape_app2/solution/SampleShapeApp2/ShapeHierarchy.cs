/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-09
*/
public interface IArea
{
    double Area{get;}
    int CompareArea(IArea Other);
    double UnionArea(IArea Other);
}
public abstract class Shape:IArea
{
    //property
    public abstract double Area{get;}
    //method
    public int CompareArea(IArea Other)=> this.Area>Other.Area?1:0;
    public double UnionArea(IArea Other)=> this.Area+Other.Area;
}
public class Rectangle:Shape
{
    //field
    private double _Width,_Height;
    //property
    public double Width{get=>_Width;set=>_Width = value>0?value:throw new System.Exception("Width > 0");}
    public double Height{get=>_Height;set=>_Height = value>0?value:throw new System.Exception("Height > 0");}
    public override double Area {get => Width*Height;}
    public Rectangle(){_Width=0;_Height=0;}
    public Rectangle(double inputWidth,double inputHeight){Width=inputWidth;Height=inputHeight;}
}
public class Circle:Shape
{
    //field
    private double _Radius;
    //property
    public double Radius{get=>_Radius;set=>_Radius = value>0?value:throw new System.Exception("Radius > 0");}
    public override double Area {get=>Math.PI*Radius*Radius;}
    public Circle(){_Radius=0;}
    public Circle(double inputRadius){Radius=inputRadius;}
}