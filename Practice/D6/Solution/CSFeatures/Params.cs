namespace Params;

public class Parameters{
    public static void ShowNames(params object [] names){
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}