using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    // 이진 트리 노드 클래스
    public class BinaryTreeNode<T>
    {
        public T _Data { get; set; }
        public BinaryTreeNode<T> _Left { get; set; }
        public BinaryTreeNode<T> _Right { get; set; }

        public BinaryTreeNode(T data)
        {
            this._Data = data;
        }
    }

    // 이진 트리 클래스
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> _Root { get; set; }

        // 트리 데이타 출력 예
        public void PreOrderTraversal(BinaryTreeNode<T> node) 7nz6b
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node._Data);
            PreOrderTraversal(node._Left);
            PreOrderTraversal(node._Right);
        }
    }
    class BinaryTree
    {
        static void Main(string[] args)
        {
            BinaryTree<int> _btree = new BinaryTree<int>();
            _btree._Root = new BinaryTreeNode<int>(1);
            _btree._Root._Left = new BinaryTreeNode<int>(2);
            _btree._Root._Right = new BinaryTreeNode<int>(3);
            _btree._Root._Left._Left = new BinaryTreeNode<int>(4);

            _btree.PreOrderTraversal(_btree._Root);
            
//            1
//           / \
//          2   3
//         /
//        4
        }
    }
    */
}
