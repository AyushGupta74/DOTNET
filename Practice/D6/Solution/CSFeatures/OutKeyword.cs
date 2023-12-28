namespace Out;
public class OutKey{
    const float pi=3.14f;
    // float area, circumference;
    public static void Area(int rad, out float area, out float circumference){
         area= pi*rad*rad;
         circumference= 2*pi*rad;
    }
}