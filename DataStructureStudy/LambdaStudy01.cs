using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class LambdaStudy01
    {
        delegate int Method(int a, int b);      //  함수 형식
        delegate void Statement();                   //  문 형식

        static void Main(string[] args)
        {

            // 함수 형식
            Method _add = (a, b) => a + b;
            Console.WriteLine(_add(3, 4)); // 7

            Method _minus = (a, b) =>
            {
                Console.WriteLine("{0} - {1} 의 결과는?", a, b);
                return a - b;
            };
            Console.WriteLine(_minus(5, 3)); // 5 - 3 의 결과는? 2

            // 문 형식
            Statement _statement = () =>
            {
                Console.WriteLine("Test 1");
                Console.WriteLine("Test 2");
                Console.WriteLine("Test 3");
            };
            _statement();           //  호출

            //  Action 형식 (앞 뒤 같은 자료형)
            Action<int, int> _add2 = (a, b) =>
            {
                int _result = a + b;
                Console.WriteLine($"두 수의 합 : {_result}");
            };
            _add2(3, 5);

            //  Action 형식 (앞 뒤 다른 자료형)
            Action<object, string, int> _printInfo = (obj, name, age) =>
            {
                Console.WriteLine($"이름: {name}");
                Console.WriteLine($"나이: {age}");
                Console.WriteLine($"추가 정보: {obj}");
            };
            _printInfo("프로그래머", "홍길동", 30);

            // LINQ를 이용한 람다식
            Console.WriteLine("LINQ를 이용한 람다식 예제:");
            int[] _numbers = { 1, 2, 3, 4, 5 };
            var _evenNumbers = _numbers.Where(x => x % 2 == 0);
            Console.WriteLine("짝수: " + string.Join(", ", _evenNumbers));

            // 이벤트 처리를 위한 람다식
            Console.WriteLine("이벤트 처리를 위한 람다식 예제:");
            Button _Button = new Button();
            _Button._Click += (sender, e) => Console.WriteLine("버튼이 클릭되었습니다.");

            // 비동기 프로그래밍을 위한 람다식
            Console.WriteLine("비동기 프로그래밍을 위한 람다식 예제:");
            Task.Run(() =>
            {
                Console.WriteLine("비동기 작업이 실행됩니다.");
            });

            // 익명 타입 초기화를 위한 람다식
            Console.WriteLine("익명 타입 초기화를 위한 람다식 예제:");
            var _person = new { Name = "John", Age = 30 };
            Console.WriteLine($"이름: {_person.Name}, 나이: {_person.Age}");
        }

        // 이벤트 처리를 위한 가짜 Button 클래스
        class Button
        {
            // Click 이벤트
            public event EventHandler _Click;

            // 클릭 이벤트를 발생시키는 메서드
            public void PerformClick()
            {
                _Click?.Invoke(this, EventArgs.Empty);
            }
        }
    }
    */
}
