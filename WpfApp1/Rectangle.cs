using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace WpfApp1
{
    internal class Rectangle : Figure, IDrawFigureAndCalculateArea
    {
        protected double a;
        protected double b;
        public Rectangle(double x, double y, double a, double b) : base(x,y)
        {
            this.a = a;
            this.b = b;
        }

        public  double CalculateArea()
                
        {

            return a * b;
        }
        public  void DrawFigure(Canvas canvas)

        {
            canvas.Children.Clear();


            System.Windows.Shapes.Rectangle rectangle = new System.Windows.Shapes.Rectangle
            {
                Width = a,
                Height = b,
                Fill = Brushes.Red,

            };
           
            Canvas.SetLeft(rectangle, x);
            Canvas.SetTop(rectangle, y);

           
            canvas.Children.Add(rectangle);
        }

       
    }
}
