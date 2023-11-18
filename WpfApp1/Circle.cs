  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    internal class Circle : Figure, IDrawFigureAndCalculateArea
    {

        private double Radius { get; set; }
        public Circle(double x, double y, double Radius) : base(x,y)
        {
            this.Radius = Radius;
        }

        public  double CalculateArea()
        
        {
            return Math.PI * Math.Pow(Radius,2);
        }


        public void DrawFigure(Canvas canvas)
        {
            canvas.Children.Clear();

            Ellipse ellipse = new Ellipse
            {
                Width = 2 * Radius,
                Height = 2 * Radius,
                Fill = Brushes.Blue, 
            };

            
            Canvas.SetLeft(ellipse, x-Radius);
            Canvas.SetTop(ellipse, y-Radius);

           
            canvas.Children.Add(ellipse);

           
        }

    }
}
