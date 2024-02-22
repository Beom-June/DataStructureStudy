using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 35, 15, 5, 40, 10, 25, 30 };

            HeapSort _heapSort = new HeapSort();
            _heapSort.Sort(arr);

            // 출력
            Console.WriteLine("Sorted array:");
            foreach (var _print in arr)
            {
                Console.Write(_print + " ");
            }
            Console.WriteLine();
        }
    }

    class HeapSort
    {
        public void Sort(int[] arr)
        {
            int _n = arr.Length;

            // 힙 구조 생성 (배열 재배치)
            for (int i = _n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, _n, i);
            }

            // 힙에서 요소를 하나씩 추출하여 정렬
            for (int i = _n - 1; i >= 0; i--)
            {
                // 현재 루트를 끝으로 이동
                int _temp = arr[0];
                arr[0] = arr[i];
                arr[i] = _temp;

                // 축소된 힙에서 최대 힙 구조 유지
                Heapify(arr, i, 0);
            }
        }

        // 노드 i를 루트로 하는 서브트리를 힙으로 만드는 함수
        void Heapify(int[] arr, int n, int i)
        {
            int _largest = i;  // 루트를 가장 큰 값으로 초기화
            int _left = 2 * i + 1;  // 왼쪽 자식 = 2*i + 1
            int _right = 2 * i + 2;  // 오른쪽 자식 = 2*i + 2

            // 왼쪽 자식이 루트보다 크면
            if (_left < n && arr[_left] > arr[_largest])
            {
                _largest = _left;
            }

            // 오른쪽 자식이 현재 가장 큰 값보다 크면
            if (_right < n && arr[_right] > arr[_largest])
            {
                _largest = _right;
            }

            // 가장 큰 값이 루트가 아니면
            if (_largest != i)
            {
                // 교환
                int _swap = arr[i];
                arr[i] = arr[_largest];
                arr[_largest] = _swap;

                // 영향을 받은 서브트리에 대해 재귀적으로 힙 구성
                Heapify(arr, n, _largest);
            }
        }
    }
    */
}