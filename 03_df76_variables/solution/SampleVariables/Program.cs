/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-01
*/
//Declare Variable and Assignment Statement
int a,b,c;
a=20;
int d=20;

//Whole Number
//Ref: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
sbyte a1 = 20;
byte a2 = 20;
short a3 = 20;
ushort a4 = 20;
int a5 = 20;
uint a6 = 20;
long a7 = 20;
ulong a8 = 20;
nint a9 = 20;
nuint a10 = 20;

//Decimal Number
//Ref: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
float b1 = 20.5f;
double b2 = 20.5d;
decimal b3 = 20.5m;

//Character
char c1 = 'u';

//Boolean
bool d1 = true;

//String
string e1 = "Uaychai";

//Conversion
long f1 = 20;
short f2 = 50;
f1 = f2;
f2 = (short)f1;
f2 = short.Parse("50");

//null
int? g1 = null;

//Declare variable with no type
var h1 = "Uaychai";

//Array
int[] i1 = new int[3];
i1[0] = 10; i1[1] = 20; i1[2] = 30;

int[] i2 = new int[] {10,20,30};

//Two dimension array
int[,] j1 = new int[2,2];
j1[0,0] = 10; j1[0,1] = 20; j1[1,0] = 30; j1[1,1] = 40;

int[,] j2 = new int[,] {{10,20},{30,40}};

//Jagged Array
int[][] k1 = new int[2][];
k1[0] = new int[2]; k1[0][0] = 10; k1[0][1] = 20;
k1[1] = new int[] {30,40,50};

//Constant
const int l1 = 200;

//Console Readline
string input;
Console.Write("Please Input: ");
input = Console.ReadLine();
Console.WriteLine(input);