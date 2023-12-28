namespace Features;

public class GarbageColl:IDisposable{
    public string Title{get;set;}
    public double UnitPrice{get;set;}
    public GarbageColl(){
        this.Title=null;
        this.UnitPrice=0;
    }
    public void Dispose(){
        Console.WriteLine("Dispose is called");
        this.Title=null;
        GC.Collect();
        //Deterministic finalisation
        // GC.SuppressFinalize(this);
    }
    ~GarbageColl(){
        //Indeterministic finalisation
        Console.WriteLine("Finalise method is called");
    }
}