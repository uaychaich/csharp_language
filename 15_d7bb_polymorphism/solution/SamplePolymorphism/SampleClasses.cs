/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-08
*/

public abstract class Class1
{
    public abstract int Method1(int datainput1,int datainput2);
}

public class Class1_1:Class1
{   public override int Method1(int datainput1, int datainput2)=>datainput1+datainput2; }

public class Class1_2:Class1
{   public override int Method1(int datainput1, int datainput2)=>datainput1-datainput2; }

public class Class1_3:Class1
{   public override int Method1(int datainput1, int datainput2)=>datainput1*datainput2; }