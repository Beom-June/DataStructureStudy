using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 계속 재학습
namespace DataStructureStudy
{
    /*
    // 연결 리스트의 노드를 나타내는 클래스
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
    // 연결 리스트 기반의 스택 클래스
    class StackLinkedList<T>
    {
        private Node<T> _top;  // 스택의 맨 위를 가리키는 노드

        public bool IsEmpty()
        {
            return _top == null;
        }

        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = _top;
            _top = newNode;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return default(T);  // 스택이 비어있을 때 기본값 반환
            }

            T data = _top.Data;
            _top = _top.Next;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return default(T);  // 스택이 비어있을 때 기본값 반환
            }

            return _top.Data;
        }
    }

    class StackLinkedListExample
    {
        static void Main()
        {
            StackLinkedList<int> myStack = new StackLinkedList<int>();

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
