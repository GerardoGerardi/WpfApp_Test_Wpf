using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WpfApp1
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RectangleButton_Click(object sender, RoutedEventArgs e)
        {
           
          
            if (!double.TryParse(PointX.Text, out double x))
            {

                MessageBox.Show("Вы ввели неккоректное значение х", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(PointY.Text, out double y))
            {

                MessageBox.Show("Вы ввели неккоректное значение y", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            if (!double.TryParse(Aside.Text, out double a))
            {

                MessageBox.Show("Вы ввели неккоректное значение A стороны", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            if (!double.TryParse(Bside.Text, out double b))
            {

                MessageBox.Show("Вы ввели неккоректное значение В стороны", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }



            IDrawFigureAndCalculateArea drawFigure = new Rectangle(x,y,a,b);
            drawFigure.DrawFigure(DrawFigure);
            SquareForFigure.Content = $"Площадь фигуры = {drawFigure.CalculateArea()}";



        }
        private void SquareButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(PointX.Text, out double x))
            {

                MessageBox.Show("Вы ввели неккоректное значение х", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(PointY.Text, out double y))
            {

                MessageBox.Show("Вы ввели неккоректное значение y", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(AsideForSquare.Text, out double a))
            {

                MessageBox.Show("Вы ввели неккоректное значение А стороны квадрата", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

           

            IDrawFigureAndCalculateArea drawFigure = new Square(x,y,a);
            drawFigure.DrawFigure(DrawFigure);
            SquareForFigure.Content = $"Площадь фигуры = {drawFigure.CalculateArea()}";

        }

        private void TriangleButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(PointX.Text, out double x))
            {

                MessageBox.Show("Вы ввели неккоректное значение х", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(PointY.Text, out double y))
            {

                MessageBox.Show("Вы ввели неккоректное значение y", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string[] point1Coordinates = Point_1.Text.Split(':');

            if (point1Coordinates.Length != 2 || !double.TryParse(point1Coordinates[0], out double x1) || !double.TryParse(point1Coordinates[1], out double y1))
            {
                MessageBox.Show("Вы ввели некорректное значение для точки 1", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string[] point2Coordinates = Point_2.Text.Split(':');
            if (point2Coordinates.Length != 2 || !double.TryParse(point2Coordinates[0], out double x2) || !double.TryParse(point2Coordinates[1], out double y2))
            {
                MessageBox.Show("Вы ввели некорректное значение для точки 2", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string[] point3Coordinates = Point_3.Text.Split(':');
            if (point3Coordinates.Length != 2 || !double.TryParse(point3Coordinates[0], out double x3) || !double.TryParse(point3Coordinates[1], out double y3))
            {
                MessageBox.Show("Вы ввели некорректное значение для точки 3", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

        

            IDrawFigureAndCalculateArea drawFigure = new Triangle(x1,y1,x2,y2,x3,y3,x,y);
            drawFigure.DrawFigure(DrawFigure);
            
            SquareForFigure.Content = $"Площадь фигуры = {drawFigure.CalculateArea()}";

        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {

           
            if (!double.TryParse(PointX.Text,out double x))
            {

                MessageBox.Show("Вы ввели неккоректное значение х", "Ошибка ввода данных",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(PointY.Text, out double y))
            {

                MessageBox.Show("Вы ввели неккоректное значение y", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(CircleRadius.Text, out double Radius))
            {

                MessageBox.Show("Вы ввели неккоректное значение радиуса", "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            IDrawFigureAndCalculateArea drawFigure = new Circle(x, y, Radius);
            drawFigure.DrawFigure(DrawFigure);
            SquareForFigure.Content = $"Площадь фигуры = {drawFigure.CalculateArea()}";

           
        }

    }
}
