namespace AllShapes;
using Hardware;
public class Line: Shape, IPrinter{
    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}
    public Line():base(){
        this.StartPoint= new Point(0,0);
        this.EndPoint= new Point(0,0);
    }
    public Line(Point p1, Point p2, string c, int w):base(c,w){
        this.StartPoint= p1;
        this.EndPoint= p2;
    }
    public override void Draw(){
        Console.WriteLine("Drawing Line...");
    }
    public override string ToString(){
        return base.ToString()+ ", StartPoint:"+ this.StartPoint+","+" EndPoint:"+ this.EndPoint;
    }
    void IPrinter.Print(){
        Console.WriteLine("Printing Line...");
        Console.WriteLine(this);
    }
}