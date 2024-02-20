using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class BubbleSortBasic
    {
        static void Main(string[] args)
        {
            int[] _arr = { 20, 15, 1, 5, 10 };

            Console.WriteLine("버블정렬");

            Console.Write("시작값 : ");

            for (int i = 0; i < _arr.Length; i++)
            {
                Console.Write(_arr[i].ToString() + ",");
            }

            Console.WriteLine();

            //구현
            for (int i = 0; i < _arr.Length - 1; i++)
            {
                for (int j = 0; j < _arr.Length - 1 - i; j++)
                {
                    if (_arr[j] > _arr[j + 1])
                    {
                        Swap(ref _arr[j], ref _arr[j + 1]);
                    }

                    //첫번째 정렬값(0, 1) : 20, 5, 10, 15 ...
                    Console.Write((i + 1) + "번째 정렬값(" + j + ", " + (j + 1) + ") : ");

                    for (int k = 0; k < _arr.Length; k++)
                    {
                        Console.Write(_arr[k].ToString() + ", ");
                    }

                    Console.WriteLine();
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    */
}