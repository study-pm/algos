using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WF_01
{
    internal class Point : INotifyPropertyChanged
    {
        public float X { get; set; }
        public float Y { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public static double GetDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
    }
}
