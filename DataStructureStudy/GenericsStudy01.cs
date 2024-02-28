using System;

namespace DataStructureStudy
{
    /*
    class GenericsStudy01
    {
        // 제네릭 클래스 정의
        public class GenericClass<T>
        {
            // 기본 생성자
            public GenericClass() { }

            // 매개변수를 받는 생성자
            public GenericClass(T t)
            {
                _objMember = t;
            }

            // 제네릭 멤버 변수 선언
            public T _objMember { get; set; }

            // 제네릭 메서드
            public void Print<S>(S value)
            {
                Console.WriteLine(value);
            }
        }

        static void Main(string[] args)
        {
            // int 형식을 가지는 제네릭 클래스의 객체 생성
            GenericClass<int> _genericObj = new GenericClass<int>(10);

            // 제네릭 클래스의 멤버 변수 출력
            Console.WriteLine("제네릭 클래스의 멤버 변수 출력:");
            Console.WriteLine(_genericObj._objMember); // 출력 결과: 10

            // 제네릭 메서드 호출
            Console.WriteLine("제네릭 메서드 호출:");
            _genericObj.Print("Hello, Generics!"); // 출력 결과: Hello, Generics!

            // 제네릭 제약 조건을 가진 제네릭 클래스의 객체 생성
            GenericClass<string> _genericObj2 = new GenericClass<string>("Hello");
            _genericObj2.Print("World"); // 출력 결과: World

            // 제네릭 클래스의 다중 형식 사용 예제
            Console.WriteLine("제네릭 클래스의 다중 형식 사용 예제:");
            Pair<int, string> _pair = new Pair<int, string> { First = 10, Second = "Hello" };
            Console.WriteLine($"First: {_pair.First}, Second: {_pair.Second}");

            // 제네릭 클래스의 확장 메서드 사용 예제
            Console.WriteLine("제네릭 클래스의 확장 메서드 사용 예제:");
            int _number = 100;
            _number.Print(); // 출력 결과: 100

            // 제네릭 클래스의 비제네릭 메서드 사용 예제
            Console.WriteLine("제네릭 클래스의 비제네릭 메서드 사용 예제:");
            NonGenericClass<int> _nonGenericObj = new NonGenericClass<int>();
            _nonGenericObj.NonGenericMethod(); // 출력 결과: Non-generic method called.
        }
    }

    // 다중 형식을 가진 제네릭 클래스
    public class Pair<T, U>
    {
        public T First { get; set; }
        public U Second { get; set; }
    }

    // 제네릭 클래스의 확장 메서드
    public static class GenericExtensions
    {
        public static void Print<T>(this T data)
        {
            Console.WriteLine(data);
        }
    }

    // 비제네릭 메서드를 가진 제네릭 클래스
    public class NonGenericClass<T>
    {
        public void NonGenericMethod()
        {
            Console.WriteLine("Non-generic method called.");
        }
    }
    */
}
