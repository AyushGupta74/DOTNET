using PartialClass;
using Features;
using Virtual;
using Indexer;
using Nullable;
using Params;
using Reference;
using Out;
using Extension;
using Extension1;


//Partial Class
StudentPartialClass p1 = new StudentPartialClass();
p1.Email="Ayush@gmail";
p1.Location="Gokhlenagar";
p1.Name="Ayush";
p1.PRN=8;
Console.WriteLine("PartialClass->");
Console.WriteLine(p1.Email+" ,"+p1.Location+" ,"+p1.Name+" ,"+p1.PRN);

//Garbage Collection
GarbageColl g = new GarbageColl();
g.Title="Title";
Console.WriteLine(g.Title);
g.Dispose();
Console.WriteLine("After dispose()->"+g.Title);

//Shallow Copy
Stack sc = new Stack(5);
sc.arr[0]=878;
sc.arr[1]=432;
sc.arr[2]=976;
sc.arr[3]=754;
sc.arr[4]=543;
Stack sc1 = sc;
Console.WriteLine("ShallowCopy->");
foreach (int item in sc1.arr)
{
    Console.WriteLine(item);
}

//Deepcopy
Stack s1=(Stack)sc.Clone();
Console.WriteLine("DeepCopy->");
foreach (int item in s1.arr)
{
    Console.WriteLine(item);
}
Console.WriteLine(s1.arr[1]);


//Virtual and shadowing
Employee e1 = new Employee();
e1.CalculateSal();
e1.DoWork();
SalesEmployee se1 = new SalesEmployee();
se1.CalculateSal();
se1.DoWork();

//Indexer
Books myCollection=new Books();
string title=myCollection[0];
Console.WriteLine("Title= "+ title);
myCollection[3]="Who moved my Cheese";
title=myCollection[3];
Console.WriteLine("Title= "+ title);

//Nullable
MyNullable mn = new MyNullable();
Console.WriteLine("NullNumber: "+ mn.numbernull);
Console.WriteLine("NormalNumber: "+ mn.num1);
Console.WriteLine("EmptyString: "+ mn.str1);
Console.WriteLine("NullString: "+ mn.str2);

//Params
Parameters.ShowNames("ayush","pris","anshu","vicky","choti");

//Reference
Refer r= new Refer();
int a=10, b=20;
r.swap(ref a, ref b);
Console.WriteLine("Swapped: "+a+" "+b);

//Out Keyword
float area,circum;
OutKey.Area(5,out area,out circum);
Console.WriteLine("Area: "+area+", Circumference: "+circum);

//Extension Method
Extend ex = new Extend();
Console.WriteLine("Addition: "+ ex.Addition(10,20));
Console.WriteLine("Subtraction: "+ex.Subtraction(10,20));
Console.WriteLine("Multiplication: "+ex.Multiplication(10,20));
Console.WriteLine("Division: "+ex.Division(10,20));