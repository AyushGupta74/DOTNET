namespace AllShapes;
public abstract class Shape{
    public string Color{get;set;}
    public int Width{get;set;}
    public Shape():this("N/A",0){}
    public Shape(string Color, int Width){
        this.Color= Color;
        this.Width= Width;
    }
    public abstract void Draw();
    public override string ToString(){
        return "Width: "+this.Width +", Color: "+this.Color;
    }
}