namespace Extension;
using Extension1;
public static class Extended{
    public static int Multiplication(this Extend e, int a,int b){
        return a*b;
    }
    public static int Division(this Extend e, int a,int b){
        return a/b;
    }
}