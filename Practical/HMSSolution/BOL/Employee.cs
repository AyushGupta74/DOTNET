namespace BOL;

public class Employee
{
    public int Id{get; set;}
    public string Name{get; set;}
    public string Email{get; set;}
    public string Contact{get; set;}
    public Employee(){

    }
    public Employee(int id,string name,string email,string contact){
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.Contact=contact;
    }
}
