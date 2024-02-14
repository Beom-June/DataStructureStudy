using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    class BubbleSortBasic
    {
        static void Main(string[] args)
        {
            int[] nArrData = { 20, 15, 1, 5, 10 };

            Console.WriteLine("버블정렬");

            Console.Write("시작값 : ");

            for (int i = 0; i < nArrData.Length; i++)
            {
                Console.Write(nArrData[i].ToString() + ",");
            }

            Console.WriteLine();

            //구현
            for (int i = 0; i < nArrData.Length - 1; i++)
            {
                for (int j = 0; j < nArrData.Length - 1 - i; j++)
                {
                    if (nArrData[j] > nArrData[j + 1])
                    {
                        Swap(ref nArrData[j], ref nArrData[j + 1]);
                    }

                    //첫번째 정렬값(0, 1) : 20, 5, 10, 15 ...
                    Console.Write((i + 1) + "번째 정렬값(" + j + ", " + (j + 1) + ") : ");

                    for (int k = 0; k < nArrData.Length; k++)
                    {
                        Console.Write(nArrData[k].ToString() + ", ");
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
}