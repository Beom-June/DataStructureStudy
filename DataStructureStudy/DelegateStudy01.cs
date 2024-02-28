using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class DelegateStudy01
    {
        delegate void _delegate(int a, int b);
        class Program
        {
            static void Plus(int a, int b)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            }

            static void Minus(int a, int b)
            {
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            }

            static void Division(int a, int b)
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }

            static void Multiplication(int a, int b)
            {
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            }

            static void Main(string[] args)
            {
                _delegate _pd = (_delegate)Delegate.Combine(new _delegate(Plus),
                    new _delegate(Minus), new _delegate(Division), new _delegate(Multiplication));

                bool _test =  Delegate.Equals(new _delegate(Plus), new _delegate(Minus));

                _pd(20, 10);

                Console.WriteLine(_test);
            }
        }
    }
    */
}
