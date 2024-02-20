using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class QuickSort
    {
        static int[] data = { 25, 15, 60, 45, 10, 20, 5, 30 };
        static void Main(string[] args)
        {
            Console.WriteLine("퀵정렬");

            Console.Write("시작값 : ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i].ToString() + ", ");
            }

            Console.WriteLine();

            SortQuick(0, data.Length - 1);

            Console.Write("정렬값 : ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i].ToString() + ", ");
            }

            Console.WriteLine();
        }
        static void SortQuick(int nFirst, int nLast)
        {
            if (nFirst < nLast)
            {
                int _pivotdx = FuncPartition(nFirst, nLast);

                //분할 정복
                SortQuick(nFirst, _pivotdx - 1);
                SortQuick(_pivotdx + 1, nLast);
            }
        }

        static int FuncPartition(int nFirst, int nLast)
        {
            int _nLow, _nHigh, _nPivot;

            //양의 값 여기에서는 마지막 값
            _nPivot = data[nLast];

            _nLow = nFirst;
            _nHigh = nLast - 1;

            while (_nLow <= _nHigh)
            {
                while (data[_nLow] < _nPivot)
                    _nLow++;

                while (data[_nHigh] > _nPivot)
                    _nHigh--;

                if (_nLow <= _nHigh)
                {
                    Swap(data, _nLow, _nHigh);
                }
            }

            Swap(data, _nLow, nLast);

            return _nLow;
        }

        static void Swap(int[] nArrData, int nValue1, int nValue2)
        {
            int nTemp = nArrData[nValue1];
            nArrData[nValue1] = nArrData[nValue2];
            nArrData[nValue2] = nTemp;
        }
    }
    */
}