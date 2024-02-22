using System;
using System.Threading;

namespace DataStructureStudy
{
    /*
    class MultiThreadStudy01
    {
        static void MethodExample1()
        {
            Thread.Sleep(5000);
            for (int loop = 0; loop < 3; loop++)
            {
                Console.WriteLine("MethodExample1()의 loop: " + loop);
            }
        }

        static void MethodExample2()
        {
            Thread.Sleep(3000);
            for (int loop = 0; loop < 3; loop++)
            {
                Console.WriteLine("MethodExample2()의 loop: " + loop);
            }
        }

        static void MethodExample3()
        {
            for (int loop = 0; loop < 3; loop++)
            {
                Console.WriteLine("MethodExample3()의 loop: " + loop);
            }
        }

        static void MethodExample4()
        {
            for (int loop = 0; loop < 3; loop++)
            {
                Console.WriteLine("MethodExample4()의 loop: " + loop);

                // Thread 양보
                Thread.Sleep(500);
            }
        }


        static void Main(string[] args)
        {
            // 세 개의 Thread 객체
            Thread _t1 = new Thread(MethodExample1);

            Thread _t2 = new Thread(MethodExample2);
            Thread _t3 = new Thread(MethodExample3);

            // Thread 람다로 실행
            Thread _test = new Thread(() => MethodExample4());


            // 스레드 시작
            _t1.Start();

            // Join() : 함수의 종료를 보장하며 스레드가 동작시키는 중인 함수의 끝에 도달하기를 기다린 다음에 스레드를 닫는다.
            //_t1.Join();

            _t2.Start();
            _t3.Start();

            _test.Start();
        }
    }
    */
}
