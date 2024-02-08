using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    //// 리스트를 이용한 BFS
    //class Graph
    //{
    //    List<int>[] _nodes = new List<int>[]
    //    {
    //    new List<int>() { 1, 3},
    //    new List<int>() { 0, 2, 3},
    //    new List<int>() { 1 },
    //    new List<int>() { 0, 1, 4},
    //    new List<int>() { 3, 5 },
    //    new List<int>() { 4 },
    //    };

    //    public void BFSByList(int start)
    //    {
    //        bool[] _found = new bool[6];

    //        Queue<int> _q = new Queue<int>();
    //        _q.Enqueue(start);
    //        _found[start] = true;

    //        while (_q.Count > 0)
    //        {
    //            int _now = _q.Dequeue();
    //            Console.Write(_now + " ");

    //            // 인접하지 않으면 패스.
    //            foreach (int next in _nodes[_now])
    //            {
    //                // 이미 발견 했으면 스킵.
    //                if (_found[next])
    //                {
    //                    continue;
    //                }
    //                _q.Enqueue(next);
    //                _found[next] = true;
    //            }
    //        }
    //    }
    //}

    // 행렬을 이용한 BFS 구현
    //class Graph
    //{
    //    int[,] nodes = new int[6, 6]
    //    {
    //    {0, 1, 0, 1, 0, 0 },
    //    {1, 0, 1, 1, 0, 0 },
    //    {0, 1, 0, 0, 0, 0 },
    //    {1, 1, 0, 0, 1, 0 },
    //    {0, 0, 0, 1, 0, 1 },
    //    {0, 0, 0, 0, 1, 0 },
    //    };

    //    public void BFSByMatrix(int start)
    //    {
    //        bool[] _found = new bool[6];

    //        Queue<int> _q = new Queue<int>();
    //        _q.Enqueue(start);
    //        _found[start] = true;

    //        while (_q.Count > 0)
    //        {
    //            int now = _q.Dequeue();
    //            Console.Write(now + " ");

    //            for (int next = 0; next < 6; next++)
    //            {
    //                // 인접하지 않으면 패스.
    //                if (nodes[now, next] == 0)
    //                {
    //                    continue;
    //                }

    //                // 이미 발견 했으면 스킵.
    //                if (_found[next])
    //                {
    //                    continue;
    //                }

    //                _q.Enqueue(next);
    //                _found[next] = true;
    //            }
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Graph graph = new Graph();
    //        Console.WriteLine("BFS traversal starting from node 0");
    //        graph.BFSByMatrix(0);
    //    }
    //}
}
