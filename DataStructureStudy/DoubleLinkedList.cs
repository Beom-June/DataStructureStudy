using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 어려움... 복습 반복

namespace DataStructureStudy
{
    /*
    // 이중 연결 리스트의 노드를 나타내는 클래스
    public class Node<T>
    {
        public T Data { get; set; }      // 현재 노드의 데이터
        public Node<T> Next { get; set; } // 다음 노드를 가리키는 링크
        public Node<T> Prev { get; set; } // 이전 노드를 가리키는 링크

        // 노드 생성자
        public Node(T data, Node<T> next = null, Node<T> prev = null)
        {
            Data = data;
            Next = next;
            Prev = prev;
        }
    }

    // 이중 연결 리스트를 나타내는 클래스
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; set; } // 리스트의 첫 번째 노드를 가리키는 링크
        public Node<T> Tail { get; set; } // 리스트의 마지막 노드를 가리키는 링크
        public int Count { get; private set; } // 리스트의 노드 수

        // 리스트의 모든 요소를 출력하는 메서드
        public void PrintAll()
        {
            Node<T> currentNode = Head;
            Console.Write("[");

            while (currentNode != null)
            {
                Console.Write(currentNode.Data);

                currentNode = currentNode.Next;
                if (currentNode != null)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }

        // 리스트를 비우는 메서드
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        // 주어진 인덱스에 데이터를 삽입하는 메서드
        public void InsertAt(int index, T data)
        {
            if (index > Count || index < 0)
            {
                throw new InvalidOperationException("범위를 넘어갔습니다.");
            }

            Node<T> newNode = new Node<T>(data);

            if (index == 0)
            {
                // 리스트의 맨 앞에 삽입
                newNode.Next = Head;
                if (Head != null)
                {
                    Head.Prev = newNode;
                }
                Head = newNode;

                if (newNode.Next == null)
                {
                    // 리스트가 비어있을 때
                    Tail = newNode;
                }
            }
            else if (index == Count)
            {
                // 리스트의 맨 뒤에 삽입
                newNode.Next = null;
                newNode.Prev = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }
            else
            {
                // 중간에 삽입
                Node<T> currentNode = Head;

                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }

                newNode.Next = currentNode.Next;
                newNode.Prev = currentNode;
                currentNode.Next = newNode;
                newNode.Next.Prev = newNode;
            }

            Count++;
        }

        // 리스트의 마지막에 데이터를 삽입하는 메서드
        public void InsertLast(T data)
        {
            InsertAt(Count, data);
        }

        // 주어진 인덱스에 있는 데이터를 삭제하는 메서드
        public Node<T> DeleteAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new InvalidOperationException("제거할 수 없습니다.");
            }

            Node<T> currentNode = Head;

            if (index == 0)
            {
                // 리스트의 맨 앞에서 삭제
                Node<T> deletedNode = Head;

                if (Head.Next == null)
                {
                    // 리스트에 노드가 하나뿐일 때
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Next;
                    Head.Prev = null;
                }

                Count--;
                return deletedNode;
            }
            else if (index == Count - 1)
            {
                // 리스트의 맨 뒤에서 삭제
                Node<T> deletedNode = Tail;
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
                Count--;
                return deletedNode;
            }
            else
            {
                // 중간에서 삭제
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }

                Node<T> deletedNode = currentNode.Next;
                currentNode.Next = currentNode.Next.Next;
                currentNode.Next.Prev = currentNode;
                Count--;
                return deletedNode;
            }
        }

        // 리스트의 마지막 노드를 삭제하는 메서드
        public Node<T> DeleteLast()
        {
            return DeleteAt(Count - 1);
        }

        // 주어진 인덱스에 있는 노드를 반환하는 메서드
        public Node<T> GetNodeAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new InvalidOperationException("범위를 넘어갔습니다.");
            }

            Node<T> currentNode = Head;

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 이중 연결 리스트 객체 생성
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

            // 데이터 삽입
            doublyLinkedList.InsertLast(1);
            doublyLinkedList.InsertLast(2);
            doublyLinkedList.InsertLast(3);

            // 전체 출력
            Console.WriteLine("전체 출력:");
            doublyLinkedList.PrintAll();

            // 데이터 삭제
            doublyLinkedList.DeleteAt(1);

            // 전체 출력
            Console.WriteLine("삭제 후 출력:");
            doublyLinkedList.PrintAll();

            // 추가적인 동작 수행 가능

            // 리스트 비우기
            doublyLinkedList.Clear();

            // 전체 출력 (비워진 상태)
            Console.WriteLine("리스트 비우기 후 출력:");
            doublyLinkedList.PrintAll();
        }
    }
    */
}
