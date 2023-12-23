namespace PaintDemo;
using AllShapes;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Line l1 = new Line();
        // l1.Color="Blue";
        // l1.Width=5;
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}