using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
namespace WpfApp1
{
    internal class Triangle : Figure, IDrawFigureAndCalculateArea
    {
        private double x1 { get; set; }  
        private double y1 { get; set; } 
        private double x2 { get; set; }  
        private double y2 { get; set; }
        private double x3 { get; set; }
        private double y3 { get; set; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3,double x, double y) : base(x, y)
        
        {
            this.x1 = x1;
            this.y1 = y1;   
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }


        public double CalculateArea()

        {
            return 0.5 * (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) + Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)) + Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)));


        }

        public void DrawFigure(Canvas canvas)
        {
            canvas.Children.Clear();

            PointCollection trianglePoints = new PointCollection
        {
            new Point(x1, y1),
            new Point(x2, y2),
            new Point(x3, y3)
        };
            Polygon triangle = new Polygon
            {
               
                Points = trianglePoints,
                Fill = Brushes.Green
            };
            Canvas.SetTop(triangle, y);
            Canvas.SetLeft(triangle, x);

            canvas.Children.Add(triangle);
        }
    }
}
