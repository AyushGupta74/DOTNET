namespace Graphic;

public struct Colors{
    private int r;
    private int g;
    private int b;

    public Colors(){
        this.r=0;
        this.g=0;
        this.b=0;
    }
    public Colors(int r,int g, int b){
        this.r=r;
        this.g=g;
        this.b=b;
    }

    public override string ToString(){
        return this.r+" "+this.g+" "+this.b;
    }
}