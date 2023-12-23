namespace emp;
public sealed class WageEmployee:Employee{

    public int WorkingHours{get;set;}

    public WageEmployee():this(3,"Aditya Gpt",0){}

    public WageEmployee(int id, string fullName, int whr):base(id, fullName){
        this.WorkingHours=whr;
    }

    public override int ComputePay(){
        return base.ComputePay()+this.WorkingHours*1000;
    }

    public override string ToString(){
        return base.ToString()+" "+ this.WorkingHours;
    }
}