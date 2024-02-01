using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    // 우선 순위 큐
    class PriorityQueue
    {
        // 힙 트리는 배열로 관리할 수 있다.
        List<int> _heap = new List<int>();

        public void Push(int data)
        {
            // 힙의 맨 끝에 새로운 데이터를 삽입한다.
            _heap.Add(data);

            int _now = _heap.Count - 1;  // 추가한 노드의 위치. 힙의 맨 끝에서 시작.

            // 위로 도장 깨기 시작
            while (_now > 0)
            {
                int _next = (_now - 1) / 2;  // 부모 노드
                if (_heap[_now] < _heap[_next])  // 부모 노드와 비교
                    break;

                // 두 값을 서로 자리 바꿈
                int _temp = _heap[_now];
                _heap[_now] = _heap[_next];
                _heap[_next] = _temp;

                // 검사 위치로 이동한다.
                _now = _next;
            }
        }

        public int Pop()  // 최대값(루트)을 뽑아낸다.
        {
            // 반환할 데이터를 따로 저장
            int _ret = _heap[0];

            // 마지막 데이터를 루트로 이동시킨다.
            int _lastIndex = _heap.Count - 1;
            _heap[0] = _heap[_lastIndex];
            _heap.RemoveAt(_lastIndex);
            _lastIndex--;

            // 아래로 도장 깨기 시작
            int _now = 0;
            while (true)
            {
                int _left = 2 * _now + 1;
                int _right = 2 * _now + 2;

                int _next = _now;
                // 왼쪽 값이 현재값보다 크면, 왼쪽으로 이동
                if (_left <= _lastIndex && _heap[_next] < _heap[_left])
                    _next = _left;
                // 오른쪽 값이 현재값(왼쪽 이동 포함)보다 크면, 오른쪽으로 이동
                if (_right <= _lastIndex && _heap[_next] < _heap[_right])
                    _next = _right;

                // 왼쪽/오른쪽 모두 현재값보다 작으면 종료
                if (_next == _now)
                    break;

                // 두 값 서로 자리 바꿈
                int _temp = _heap[_now];
                _heap[_now] = _heap[_next];
                _heap[_next] = _temp;

                // 검사 위치로 이동한다.
                _now = _next;
            }

            return _ret;
        }

        public int Count()
        {
            return _heap.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue _q = new PriorityQueue();
            _q.Push(20);
            _q.Push(10);
            _q.Push(30);
            _q.Push(90);
            _q.Push(40);

            while (_q.Count() > 0) // 90 40 30 20 10 출력
            {
                Console.Write(_q.Pop() + " ");
            }
        }
    }
    */
}