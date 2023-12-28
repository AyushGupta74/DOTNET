namespace Virtual;
public class Employee{
    //Virtual
    public virtual void CalculateSal(){
        Console.WriteLine("In Employee Calculate salary");
    }
    public virtual void DoWork(){
        Console.WriteLine("In Employee DoWork");
    }
}

public class SalesEmployee:Employee{

    //Shadowing
    public new virtual void CalculateSal(){
        Console.WriteLine("In SalesEmployee Calculate salary");
    }
    public override void DoWork(){
        Console.WriteLine("In SalesEmployee DoWork");
    }
}