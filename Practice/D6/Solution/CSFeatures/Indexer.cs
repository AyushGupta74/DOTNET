namespace Indexer;

public class Books{
    private string[] arr;
    public Books(){
        arr= new string[5];
        this.arr[0]="You can Win";
        this.arr[1]="Ignited Minds";
        this.arr[2]="Rich Dad, Poor Dad";
        this.arr[3]="Let us C";
        this.arr[4]="Effective C++";
    }

    //Indexer
    public string this[int index]{
        get{return arr[index];}
        set{arr[index]=value;}
    }
}