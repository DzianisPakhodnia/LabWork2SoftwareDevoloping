using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LabWork2
{
    public class Calculator
    {
        private double result;
        public double firstValue {  get; set; }
        public double secondValue { get; set; }
        public char operation { get; set; }

        public double PerformOperation()
        {
            switch (operation)
            {
                case '+':
                    return Add();
                case '-':
                    return Subtract();
                case '*':
                    return Multiply();
                case '/':
                    return Divide();
                default:
                    throw new ArgumentException("Invalid operation.");
            }
        }
        public double Add()
        {
            result = firstValue+secondValue;
            firstValue = result;
            return result;
        }

        public double Subtract()
        {
            result = firstValue - secondValue;
            firstValue = result;
            return result;
        }

        public double Multiply()
        {
            result = firstValue * secondValue;
            firstValue = result;
            return result;
        }
        public double Divide()
        {
            try
            {
                result = firstValue / secondValue;
                firstValue = result;
                return result;
            }
            catch 
            {
                return result;
            }
        }
    }
}
