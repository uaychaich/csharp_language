/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-10
*/
public partial struct Structure1
{
    private int _Data1;
    public int Data1{get=>_Data1;set=>_Data1=value;}
    public int Method1(int input1, int input2){return input1+input2+Method2(5,3);}
    public partial int Method2(int input1,int input2);
}