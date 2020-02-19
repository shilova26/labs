using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator : ICalc
    {
        public double memory { get; set; }

        public void Clear()
        {
            memory = 0;
        }

        public double Divide(double num)
        {
            return this.memory/num;
        }


        public double Minus(double num)
        {
            return this.memory - num;
        }

        public double Mod(double num)
        {
            return this.memory % num;
        }

        public double Multiply(double num)
        {
            return this.memory * num;
        }

        public double Plus(double num)
        {
            return this.memory + num;
        }

        public void Save(double num)
        {
            this.memory=num;
        }

        public double Sign(double num)
        {
           return -1*num;
        }

        public double Sqrt(double num)
        {
            return Math.Sqrt(num);
        }
    }
}
