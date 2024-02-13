using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    class Graph
    {
        private int _v; // 그래프의 노드(정점) 수
        private List<int>[] _adList; // 그래프의 인접 리스트

        public Graph(int v)
        {
            _v = v;
            _adList = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                _adList[i] = new List<int>();
            }
        }

        // 그래프에 간선을 추가합니다.
        public void AddEdge(int v, int w)
        {
            _adList[v].Add(w);
        }

        // DFS로 그래프를 탐색하고 결과를 출력합니다.
        public void DFS(int startNode)
        {
            // 방문한 노드를 추적하기 위한 배열
            bool[] visited = new bool[_v];

            // 시작 노드에서 DFS 탐색 시작
            DFSUtil(startNode, visited);
        }

        private void DFSUtil(int node, bool[] visited)
        {
            // 현재 노드를 방문한 것으로 표시하고 출력
            visited[node] = true;
            Console.Write(node + " ");

            // 현재 노드와 연결된 방문하지 않은 노드를 재귀적으로 탐색
            foreach (int adjacentNode in _adList[node])
            {
                if (!visited[adjacentNode])
                {
                    DFSUtil(adjacentNode, visited);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Graph graph = new Graph(7);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 5);
            graph.AddEdge(2, 6);

            Console.WriteLine("DFS 탐색 결과 (시작 노드: 0):");
            graph.DFS(0);
        }
    }
}
