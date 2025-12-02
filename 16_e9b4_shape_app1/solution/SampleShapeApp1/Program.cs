/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-08
*/

Rectangle rec1 = new Rectangle(10,20);
Rectangle rec2 = new Rectangle(20,30);

Circle cir1 = new Circle(10);
Circle cir2 = new Circle(15);

Console.WriteLine($"{cir1.CompareArea(rec1)} | {cir1.UnionArea(cir2)}");