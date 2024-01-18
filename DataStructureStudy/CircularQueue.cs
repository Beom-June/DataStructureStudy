using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class CircularQueue
    {
        private const int _MAX_SIZE = 100;
        private int[] _arr = new int[_MAX_SIZE];
        private int _front = -1;
        private int _rear = -1;

        public bool IsEmpty()
        {
            // Queue가 비어있는지 여부 확인
            return _front == -1;
        }

        public bool IsFull()
        {
            // Queue가 가득 찼는지 여부 확인
            return (_rear + 1) % _MAX_SIZE == _front;
        }

        public void Enqueue(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full.");
                return;
            }

            if (IsEmpty())
            {
                // Queue가 비어있으면 front를 0으로 초기화
                _front = 0;
            }

            // rear를 다음 위치로 이동하고 값을 Queue에 추가
            // 원형 큐에서 인덱스를 순환시키기 위한 계산
            // 계산의 목적은 원형 큐에서 인덱스를 순환시켜
            // 배열의 끝에 도달하면 다시 배열의 처음으로 돌아가게 하는 것
            // (현재 인덱스 + 1) % 큐의 최대 크기를 통해 배열의 끝에 도달하면 인덱스가 0으로 돌아가게 됨
            _rear = (_rear + 1) % _MAX_SIZE;
            _arr[_rear] = value;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return -1;
            }
            // front가 현재 가리키는 값 반환
            int value = _arr[_front];

            if (_front == _rear)
            {
                // Queue에 마지막 요소가 남아있는 경우 front와 rear 초기화
                _front = -1;
                _rear = -1;
            }
            else
            {
                // front를 다음 위치로 이동
                _front = (_front + 1) % _MAX_SIZE;
            }
            // 큐에서 꺼낸 값 반환
            return value;
        }
    }
    class QueueExample
    {
         static void Main()
        {
            CircularQueue _Queue = new CircularQueue();

            _Queue.Enqueue(1);
            _Queue.Enqueue(2);
            _Queue.Enqueue(3);

            while (!_Queue.IsEmpty())
            {
                Console.WriteLine($"Dequeued: {_Queue.Dequeue()}");
            }
        }
    }
    */
}
