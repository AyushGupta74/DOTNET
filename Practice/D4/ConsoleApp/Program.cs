using AllShapes;
using Hardware;

List<Shape> shapes=new List<Shape>();

Line l1 = new Line();
l1.StartPoint = new Point(10,20);
l1.EndPoint = new Point(30,40);
l1.Color="Blue";
l1.Width=1;

Circle c1 = new Circle();
c1.center= new Point(25,35);
c1.radius= 5;
c1.Color="Orange";
c1.Width=5;

Console.WriteLine(l1);
Console.WriteLine(c1);

shapes.Add(l1);
shapes.Add(c1);

Console.WriteLine("All shapes showing");
foreach( Shape s in shapes)
{
    Console.WriteLine(s);
}