using MulticastDelegate.Services;
using System;

namespace MulticastDelegate
{
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            //para chamar as funções a serem executadas - ou op.Invoke(a, b)
            op(a, b);
        }
    }
}