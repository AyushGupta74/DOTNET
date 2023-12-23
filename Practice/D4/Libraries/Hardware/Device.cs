namespace Hardware;

public class HP: IPrinter, IScanner{
    public void Print(){
        Console.WriteLine("Printer has started...");
    }
    public void Scan(){
        Console.WriteLine("Scanner has started...");
    }
}