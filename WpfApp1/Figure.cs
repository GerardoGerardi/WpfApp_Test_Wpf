using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    internal class Figure
    {
        protected double x { get; set; }
        protected double y { get; set; }


       
        public Figure(double x, double y)

        {
            this.x = x;
            this.y = y;
        }




    }
}
