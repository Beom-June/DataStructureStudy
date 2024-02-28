using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class EventSutdy01
    {
        public delegate void MyEventHandler(string message);

        class Publisher
        {
            public event MyEventHandler _Active;

            public void DoActive(int number)
            {
                if (number % 10 == 0)
                    _Active("Active!" + number);
                else
                    Console.WriteLine(number);
            }
        }

        class Subscriber
        {
            static public void MyHandler(string message)
            {
                Console.WriteLine(message);
            }

            static void Main(string[] args)
            {
                Publisher _publisher = new Publisher();
                _publisher._Active += new MyEventHandler(MyHandler);

                for (int i = 1; i < 50; i++)
                    _publisher.DoActive(i);
            }
        }
    }
    */
}
