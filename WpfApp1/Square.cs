using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    internal class Square : Rectangle
    {

        public Square(double x, double y,double a) : base(x,y,a,a)
        {
            
        }

       
    }
}
