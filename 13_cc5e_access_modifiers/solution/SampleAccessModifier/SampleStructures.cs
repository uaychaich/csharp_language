/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-08
*/
public struct SampleStruct1
{
    //field
    public int _Data1;
    private int _Data2;
    //property
    public int Data1{get=>_Data1;set=>_Data1=value;}
    private int Data2{get=>_Data2;set=>_Data2=value;}
    //method
    public int getData1()=>_Data1;
    private int getData2()=>_Data2;
    public SampleStruct1(){Data1=100;Data2=200;}
    public SampleStruct1(int inputData1,int inputData2){Data1=inputData1;Data2=inputData2;}
}