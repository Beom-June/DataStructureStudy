using System;
using System.Threading;

// lock 문법 학습
namespace DataStructureStudy
{
    /*
    class MultiThreadStudy02
    {
        public class Vilige
        {
            public int _population = 1000;

            public object _populationLock = new object();

            public void AddHuman()
            {
                // Thread 동기화
                lock (_populationLock)
                {
                    _population++;

                    for (int i = 0; i < _population; i++)
                    {
                        for (int j = 0; j < _population; j++)
                        {
                        }
                    }
                    // 추가된 주민에게 주민번호 주기
                    Console.WriteLine(string.Format("새 주민의 주민번호 :: {0}", _population));
                }
            }
        }

        public static void Main(string[] args)
        {
            Vilige _vilige = new Vilige();
            for (int i = 0; i < 10; i++)
            {
                new Thread(new ThreadStart(_vilige.AddHuman)).Start();
            }

        }
    }
    */
}
