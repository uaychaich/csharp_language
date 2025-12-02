/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-09
*/

public class Class1:Interface2,Interface3
{
    private int _Data;
    public int Data{get=>_Data;set=>_Data=value;}
    public int ProcessData(int otherdata){return Data+otherdata;}
    public int ProcessData2(int otherdata){return Data+otherdata;}
    public int ProcessData3(int otherdata){return Data+otherdata;}
}

public class Class2:Interface1
{
    private int _Data;
    public int Data{get=>_Data;set=>_Data=value+5;}
    public int ProcessData(int otherdata){return Data*otherdata;}
}