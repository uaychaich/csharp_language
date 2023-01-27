/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-05
*/
public class SampleStructureMethod
{
    public void method1(int input1){}
    public void method1(int input1, int input2, int input3=5){}

    public void method2(int input1, out int output1)
    {output1=6;}

    public void method3(params int[] inputlist){}

    public int method4()
    {return 5;}

    public int method5(int input1,int input2) => input1+input2;
}

public class PeopleStructure
{
    //field
    public string _FirstName="", _LastName="";
    public double _Height;
    
    //property
    public string FirstName{set=>_FirstName=value; get=>_FirstName;}
    public string LastName{set=>_LastName=value;get=>_LastName;}
    public double Height{set=>_Height= value>0?value:throw new ArgumentException("Height MUST be more than 0"); 
                         get=>_Height;}
    
    //method
    public int CompareHeight(double OtherHeight)=> this.Height > OtherHeight?1:0;
    public int CompareHeight(PeopleStructure Other)=> this.Height > Other.Height?1:0; 
}