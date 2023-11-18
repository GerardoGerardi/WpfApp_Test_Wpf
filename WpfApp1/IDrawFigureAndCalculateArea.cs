﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    internal interface IDrawFigureAndCalculateArea
    {
       
       void DrawFigure(Canvas canvas);
       double CalculateArea();

    }
}
