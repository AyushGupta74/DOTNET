namespace P1;

class Person{
    private int id;
    private string firstName;
    private string lastName;

    public Person(){
        this.id=1;
        this.firstName="Pris";
        this.lastName="Debb";
    }

    public Person(int id, string firstName, string lastName){
        this.id=id;
        this.firstName=firstName;
        this.lastName=lastName;
    }

    public override string ToString(){
        return this.id+" "+this.firstName+" "+this.lastName+" ";
    }
}