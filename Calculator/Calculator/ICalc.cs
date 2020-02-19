using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalc
    {
        double memory { get; set; }
        void Save(double num);
        double Divide(double num);
        double Minus(double num);
        double Plus(double num);
        double Multiply(double num);
        double Sqrt(double num);
        double Sign(double num);
        double Mod(double num);
        void Clear();


    }
}
