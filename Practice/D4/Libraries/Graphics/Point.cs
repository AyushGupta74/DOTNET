namespace AllShapes;
public class Point{
    public int x{get;set;}
    public int y{get;set;}
    public Point():this(0,0){}
    public Point(int x,int y){
        this.x=x;
        this.y=y;
    }
    public override string ToString(){
        string str = string.Format(" X = {0}, Y = {1}", this.x, this.y);
        return str;
    }
}