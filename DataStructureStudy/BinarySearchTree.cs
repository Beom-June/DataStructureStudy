using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    // 이진 탐색 트리 노드
    public class BinarySearchTree
    {
        public class Node
        {
            public int _value;
            public Node _left;
            public Node _right;

            public Node(int value)
            {
                _value = value;
                _left = null;
                _right = null;
            }
        }

        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = InsertRecursively(Root, value);
        }

        private Node InsertRecursively(Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value);
                return node;
            }

            if (value < node._value)
            {
                node._left = InsertRecursively(node._left, value);
            }
            else if (value > node._value)
            {
                node._right = InsertRecursively(node._right, value);
            }

            return node;
        }

        // 요소 탐색
        public bool Search(int value)
        {
            return SearchRecursively(Root, value);
        }

        private bool SearchRecursively(Node node, int value)
        {
            if (node == null)
            {
                // 노드가 null이면 요소가 트리에 없음
                return false;
            }

            if (value == node._value)
            {
                // 값이 일치하면 요소를 찾음
                return true;
            }
            else if (value < node._value)
            {
                // 값이 현재 노드의 값보다 작으면 왼쪽 서브트리에서 계속 탐색
                return SearchRecursively(node._left, value);
            }
            else
            {
                // 값이 현재 노드의 값보다 크면 오른쪽 서브트리에서 계속 탐색
                return SearchRecursively(node._right, value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree _bst = new BinarySearchTree();

            // 요소 삽입
            _bst.Insert(50);
            _bst.Insert(30);
            _bst.Insert(20);
            _bst.Insert(40);
            _bst.Insert(70);
            _bst.Insert(60);
            _bst.Insert(80);

            // 요소 탐색
            Console.WriteLine(_bst.Search(20)); // 출력: True
            Console.WriteLine(_bst.Search(45)); // 출력: False

            //    50
            //   /  \
            //  30   70
            // / \   / \
            //20  40 60  80
        }
    }
    */
}
