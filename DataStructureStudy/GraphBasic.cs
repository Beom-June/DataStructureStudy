using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    public struct myGraph
    {
        public int _numV; // 정점의 수
        public int _numE; // 간선의 수
        public List<Vertex>[] _vArray; // 인접 리스트 배열
    }

    public enum Vertex
    {
        A, B, C, D, E, F = 5, G, H, I, J
    }

    public class GraphExample
    {
        static myGraph _graph = new myGraph();

        static void Main()
        {
            GraphInit(10); // 그래프 초기화 (10개의 정점을 가정)
            AddEdge(Vertex.A, Vertex.B); // A에서 B로 간선 추가
            AddEdge(Vertex.B, Vertex.C); // B에서 C로 간선 추가
            AddEdge(Vertex.C, Vertex.D); // C에서 D로 간선 추가
            AddEdge(Vertex.D, Vertex.E); // D에서 E로 간선 추가
            AddEdge(Vertex.E, Vertex.F); // E에서 F로 간선 추가

            ShowGraphEdgeInfo(); // 그래프 간선 정보 출력
        }

        // 그래프 초기화 메서드
        static void GraphInit(int numV)
        {
            _graph._numV = numV; // 정점의 수 초기화
            _graph._numE = 0; // 간선의 수 초기화
            _graph._vArray = new List<Vertex>[numV]; // 인접 리스트 배열 초기화

            for (int i = 0; i < numV; i++)
            {
                _graph._vArray[i] = new List<Vertex>(); // 각 정점의 인접 리스트 초기화
            }
        }

        // 간선 추가 메서드
        static void AddEdge(Vertex fromV, Vertex toV)
        {
            if (!_graph._vArray[(int)fromV].Contains(toV))
            {
                _graph._numE++; // 간선의 수 증가
                _graph._vArray[(int)fromV].Add(toV); // fromV에서 toV로의 간선 추가
                _graph._vArray[(int)toV].Add(fromV); // toV에서 fromV로의 간선 추가
            }
        }

        // 그래프 간선 정보 출력 메서드
        static void ShowGraphEdgeInfo()
        {
            for (int i = 0; i < _graph._numV; i++)
            {
                Console.Write((Vertex)i + " : ");
                foreach (var vertex in _graph._vArray[i])
                {
                    Console.Write(vertex + ", ");
                }
                Console.Write("\n");
            }
        }
    }
    */
}
