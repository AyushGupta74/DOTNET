namespace AllShapes;
using Hardware;
public class Circle: Shape, IPrinter{
    public Point center{get;set;}
    public int radius{get;set;}
    public Circle():base(){
        this.center= new Point(0,0);
        this.radius= 0;
    }
    public Circle(Point p1, int r, string c, int w):base(c, w){
        this.center= p1;
        this.radius= 0;
    }
    public override void Draw(){
        Console.WriteLine("Drawing Circle...");
    }
    public override string ToString(){
        float pi = 3.14f;
        float area = pi*this.radius*this.radius;
        return base.ToString()+ ", Center: "+ this.center+" Radius: "+this.radius+" Area: "+area;
    }
    void IPrinter.Print(){
        Console.WriteLine("Printing Circle...");
        Console.WriteLine(this);
    }
}