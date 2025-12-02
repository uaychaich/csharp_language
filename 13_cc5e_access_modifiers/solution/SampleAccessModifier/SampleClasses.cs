/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-08
*/

public class SampleClass1
{
    //field
    public int _Data1;
    private int _Data2;
    protected int _Data3;
    //property
    public int Data1{get=>_Data1;set=>_Data1=value;}
    private int Data2{get=>_Data2;set=>_Data2=value;}
    protected int Data3{get=>_Data3;set=>_Data3=value;}
    //method
    public int getData1()=>_Data1;
    private int getData2()=>_Data2;
    protected int getData3()=>_Data3;
    public SampleClass1(){Data1=100;Data2=200;Data3=300;}
    public SampleClass1(int inputData1,int inputData2,int inputData3){Data1=inputData1;Data2=inputData2;Data3=inputData3;}
}

public class SampleClass1_1: SampleClass1
{
    public SampleClass1_1(){Data1=1000;Data3=3000;}
    public SampleClass1_1(int inputData1,int inputData3){Data1=inputData1;Data3=inputData3;}
}

public class SampleClass1_2: SampleClass1
{
    private SampleClass1_2(){}
    public SampleClass1_2(int inputData1,int inputData3){Data1=inputData1;Data3=inputData3;}
}
