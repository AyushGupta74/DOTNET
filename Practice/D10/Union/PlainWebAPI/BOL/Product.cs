namespace pwa.bol;

public class Product
{
    private int id;
    private string title;
    private double unitprice;
    private string company;

    public Product(){
    }

    public Product(int id){
        this.id = id;   
    }

    public Product(int id, string title){
        this.id = id;
        this.title = title;
    }

    public Product(int id, string title, double unitprice){
        this.id = id;
        this.title = title;       
        this.unitprice = unitprice;
    }

     public Product(int id, string title, double unitprice, string company){
        this.id = id;
        this.title = title;
        this.unitprice = unitprice;
        this.company = company;
    }

    public int PID{
        get{return this.id;}
        set{this.id=value;}
    }
    public string TITLE{
        get{return this.title;}
        set{this.title=value;}
    }
    public double UNITPRICE{
        get{return this.unitprice;}
        set{this.unitprice=value;}    
    }
    public string COMPANY{
        get{return this.company;}
        set{this.company=value;}    
    }

}