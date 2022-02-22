using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace testeDeUnidade
{
    public class calcular
    {
        public double a;
        public double b;

        public double add(double a, double b)
        {
            return a + b;
        }
    }

    public class CalcularTest
    {
        public void add2e2()
        {
            double a = 2;
            double b = 2;
            double espected = 4;

            calcular calc = new calcular();

            double actual = calc.add(a, b);

            Assert.Equal(espected, actual);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularTest c = new CalcularTest();

            c.Equals(c);
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
