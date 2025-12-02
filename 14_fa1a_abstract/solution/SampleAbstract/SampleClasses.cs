/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-08
*/
public class SampleClass1
{
    public virtual int Method1(int inputdata1, int inputdata2){return 5;}
}
public class SampleClass1_1:SampleClass1
{
    public override int Method1(int inputdata1, int inputdata2)
    {   return inputdata1 + inputdata2;    }
}

public abstract class SampleClass2
{
    public abstract int Prop1{get;set;}
    public abstract int Method1(int inputdata1,int inputdata2);
}
public class SampleClass2_1:SampleClass2
{
    private int _Prop1;
    public override int Prop1 { get => _Prop1; set => _Prop1 = value; }
    public override int Method1(int inputdata1, int inputdata2)
    {
        return inputdata1+inputdata2;
    }
    public SampleClass2_1(){Prop1=500;}
}