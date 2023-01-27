/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-09
*/

public interface Interface1
{
    //property
    int Data{get;set;}
    //method
    int ProcessData(int otherdata);
}

public interface Interface2:Interface1
{
    int ProcessData2(int otherdata);
}

public interface Interface3
{
    int ProcessData3(int otherdata);
}