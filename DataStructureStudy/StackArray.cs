using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class StackArray
    {
        private const int _MAX_SIZE = 100;
        private int[] _stackArray = new int[_MAX_SIZE];
        private int _top = -1;  // 스택의 맨 위를 가리키는 인덱스

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public bool IsFull()
        {
            return _top == _MAX_SIZE - 1;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full.");
                return;
            }

            _stackArray[++_top] = value;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return -1;  // 스택이 비어있을 때 특정 값 반환
            }

            return _stackArray[_top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return -1;  // 스택이 비어있을 때 특정 값 반환
            }

            return _stackArray[_top];
        }
    }

    // 실행
    class Program
    {
        static void Main()
        {
            StackArray myStack = new StackArray();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            Console.WriteLine("Peek: " + myStack.Peek());

            while (!myStack.IsEmpty())
            {
                Console.WriteLine("Popped: " + myStack.Pop());
            }
        }
    }
    */
}