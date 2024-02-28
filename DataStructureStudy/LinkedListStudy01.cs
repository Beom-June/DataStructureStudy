using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class LinkedListStudy01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Example 01 ****");
            LinkedList<string> _list01 = new LinkedList<string>();
            _list01.AddLast("Apple");
            _list01.AddLast("Banana");
            _list01.AddLast("Lemon");

            LinkedListNode<string> _node01 = _list01.Find("Banana");
            LinkedListNode<string> _newNode = new LinkedListNode<string>("Grape");

            // 새 Grape 노드를 Banana 노드 뒤에 추가
            _list01.AddAfter(_node01, _newNode);

            // 리스트 출력
            _list01.ToList<string>().ForEach(p => Console.WriteLine(p));

            // Enumerator 리스트 출력
            foreach (var item in _list01)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Example 02 ****");
            LinkedList<int> _list02 = new LinkedList<int>(new[] { 1, 2, 3, 4 });
            LinkedListNode<int> _node02 = _list02.Last;

            Console.WriteLine("**** 요소 가져오기 ****");
            // 첫 번째 요소 가져오기
            Console.WriteLine(_list02.First.Value);
            // 마지막 요소 가져오기
            Console.WriteLine(_list02.Last.Value);

            Console.WriteLine("**** 요소 추가 ****");
            _list02.AddFirst(5);
            Console.WriteLine("첫 번째 요소 추가 후 리스트: " + string.Join(", ", _list02));
            _list02.AddLast(7);
            Console.WriteLine("마지막 요소 추가 후 리스트: " + string.Join(", ", _list02));
            _list02.AddBefore(_node02, 8);
            Console.WriteLine("마지막 노드 앞에 요소 추가 후 리스트: " + string.Join(", ", _list02));
            _list02.AddAfter(_node02, 8);
            Console.WriteLine("마지막 노드 뒤에 요소 추가 후 리스트: " + string.Join(", ", _list02));

            Console.WriteLine("**** 요소 제거 ****");
            _list02.RemoveFirst();
            Console.WriteLine("첫 번째 요소 제거 후 리스트: " + string.Join(", ", _list02));
            _list02.RemoveLast();
            Console.WriteLine("마지막 요소 제거 후 리스트: " + string.Join(", ", _list02));

            Console.WriteLine("**** 리스트에 포함된 요소의 수를 반환 ****");
            int _count = _list02.Count;
            Console.WriteLine(_count);

            Console.WriteLine("**** 모든 요소 제거 ****");
            _list02.Clear();
            Console.WriteLine("모든 요소 제거 후 리스트 : " + string.Join(", ", _list02));
        }
    }
    */
}