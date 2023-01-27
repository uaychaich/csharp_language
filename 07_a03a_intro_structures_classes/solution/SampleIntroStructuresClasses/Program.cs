/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-01
*/

//No Structure or Class
double rec_width1, rec_height1, rec_width2, rec_height2;
rec_width1 = 20.3; rec_height1 = 10.2;
rec_width2 = 12.5; rec_height2 = 5.3;

//Use Array
double[] rec1array = new double[2];
double[] rec2array = new double[2];
rec1array[0] = 20.3; rec1array[1] = 10.2;
rec2array[0] = 12.5; rec2array[1] = 5.3;

//Use Structure 
RectangleStruct rec1struct;
rec1struct = new RectangleStruct();
rec1struct.width=20.3; rec1struct.height=10.2;

RectangleStruct rec2struct = new RectangleStruct() {width=12.5,height=5.3};

//Use Class
RectangleClass rec1class;
rec1class = new RectangleClass();
rec1class.width=20.3; rec1class.height=10.2;

RectangleClass rec2class = new RectangleClass(){width=12.5,height=5.3};

//Value Type vs Reference Type
Console.WriteLine("Before");
RectangleStruct rs1 = new RectangleStruct(){width=20,height=30};
RectangleStruct rs2 = new RectangleStruct();
rs2 = rs1; 
Console.WriteLine($"rs1.width={rs1.width} rs1.height={rs1.height}");
Console.WriteLine($"rs2.width={rs2.width} rs2.height={rs2.height}");

RectangleClass rc1 = new RectangleClass(){width=20,height=30};
RectangleClass rc2 = new RectangleClass();
rc2 = rc1;
Console.WriteLine($"rc1.width={rc1.width} rc1.height={rc1.height}");
Console.WriteLine($"rc2.width={rc2.width} rc2.height={rc2.height}");

Console.WriteLine("After");
rs2.width=50; rc2.width=50;
Console.WriteLine($"rs1.width={rs1.width} rs1.height={rs1.height}");
Console.WriteLine($"rs2.width={rs2.width} rs2.height={rs2.height}");
Console.WriteLine($"rc1.width={rc1.width} rc1.height={rc1.height}");
Console.WriteLine($"rc2.width={rc2.width} rc2.height={rc2.height}");