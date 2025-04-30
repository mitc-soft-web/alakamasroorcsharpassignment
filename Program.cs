// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Q1
sbyte mysbyte = 112, b = -115, c = -44, d = 97;
byte mybyte = 112, b = 97, c = 224;
short myshort = 112, b = -115 ,c = -44, d  = 97, e =224, f = 10000, j = 20000, k =1990,
ushort myushort = 112, b = 97, c = 224, d = 20000, e = 1990, f = 52130,
int myint = 112, b = -115, c=-44, d = 97, e = 224, f = -10000, g = 20000, h = 1990, i = -1000000, j = 52130, k = 4285932,
uint a = 97u, b = 224u, c= 20000u, d = 1990u, e = 52130, f = 4825932u, g = 112u;
long a = 97, b = 224,c=20000, d = 1990, e = 52130, f = 4825932, g = 112, h = 97007000000; i = 123456789123456789;

// Q2
float myfloat = 5f, b = -5.01f, c=12.345f;
double mydouble = -5.01, b = 5, c = 12.345;
decimal a = -5.01m, b = 5m, c = 12.345m, d = 8923.1234857,3456.091124875956542151256683467m;
// Q6
bool isMale = true;
// Q7
string firstName = "Hello";
string secondName = "World";
string fullName = firstName+ " " +secondName; 
Console.WriteLine(fullName);
// Q8
string one = "Hello";
string two = "World";
object obj = one+ " " +two;
string result = (string)obj;
Console.WriteLine(result);
// // Q9
string quote ="The \"use\" of quotations causes difficulties.";
Console.WriteLine(quote);
// Q12
string firstName = "olamide";
string lastName = "adeola";
int age = 20;
char gender = 'm';
int employeenumber = 27561034;
// Q13
int a = 5;
int b = 10;
int oldA = a;
a = b;
b = oldA;
Console.WriteLine(b);
Console.WriteLine(a);
