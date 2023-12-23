namespace emp;

public class Employee{
    private int id;
    private string fullName;
    //Constructors
    public Employee(): this(0,""){}

    public Employee(int id, string fullName){
        this.id = id;
        this.fullName= fullName;
    }
    //Getter/Setter
    public int Id{
        get;
        set;
    }
    public string FullName{
        get;
        set;
    }

    public virtual int ComputePay(){
        return 5000000;
    }
    //tostring
    public override string ToString(){
        return this.id+ " "+ this.fullName;
    }
}