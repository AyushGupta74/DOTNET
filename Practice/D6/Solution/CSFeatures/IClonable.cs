namespace Features;

public class Stack: ICloneable{
    public int size;
    public int[] arr;
    public Stack(int size){
        this.size=size;
        this.arr=new int[size];
    }

    //Deep Copy Implementation
    public object Clone(){
        Stack replica = new Stack(this.size);
        this.arr.CopyTo(replica.arr,0);
        return replica;
    }
}