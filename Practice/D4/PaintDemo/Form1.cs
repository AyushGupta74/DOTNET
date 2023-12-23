using AllShapes;
using System.Drawing;
namespace PaintDemo;
public partial class Form1 : Form{
    AllShapes.Point StartPoint;
    AllShapes.Point EndPoint;
    public Form1(){
        InitializeComponent();
        // Connect the Paint event of the PictureBox to the event handler method.
        Paint += new System.Windows.Forms.PaintEventHandler(OnPaint);
        MouseDown += new System.Windows.Forms.MouseEventHandler(onMouseDown);
        MouseUp += new System.Windows.Forms.MouseEventHandler(onMouseUp);
    }
    //Event Handlers
    public void OnPaint(object sender, PaintEventArgs pe){
    }
    public void onMouseDown(object sender, MouseEventArgs md){
        StartPoint = new AllShapes.Point(md.X, md.Y);
    }
    public void onMouseUp(object sender , MouseEventArgs mu){
        EndPoint = new AllShapes.Point(mu.X, mu.Y);
        Line l = new Line(StartPoint, EndPoint, "Blue", 3);
        Graphics g = this.CreateGraphics();
        Pen p = new Pen(Color.FromArgb(200,50,70,210),l.Width);
        g.DrawLine(p, l.StartPoint.x,l.StartPoint.y,l.EndPoint.x,l.EndPoint.y);
    }
}