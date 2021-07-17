using System;

namespace Treap
{
    public class Node
    {
        private readonly int _x;
        private readonly int _y;
        private readonly Node _left;
        private readonly Node _right;

        public Node(int x, int y, Node left = null, Node right = null)
        {
            _x = x;
            _y = y;
            _left = left;
            _right = right;
        }

        private static Node Merge(Node L, Node R)
        {
            if (L == null) return R;
            if (R == null) return L;

            if (L._y > R._y)
            {
                var newR = Merge(L._right, R);
                return new Node(L._x, L._y, L._left, newR);
            }
            else
            {
                var newL = Merge(L, R._left);
                return new Node(R._x, R._y, newL, R._right);
            }
        }

        private void Split(int x, out Node L, out Node R)
        {
            Node newTree = null;
            if (_x <= x)
            {
                if (_right == null)
                {
                    R = null;
                }
                else
                {
                    _right.Split(x, out newTree, out R);
                }

                L = new Node(_x, _y, _left, newTree);
            }
            else
            {
                if (_left == null)
                {
                    L = null;
                }
                else
                {
                    _left.Split(x, out L, out newTree);
                }

                R = new Node(_x, _y, newTree, _right);
            }
        }

        public Node Add(int x)
        {
            Split(x, out var l, out var r);
            var m = new Node(x, new Random().Next());
            return Merge(Merge(l, m), r);
        }

        public Node Remove(int x)
        {
            Split(x - 1, out var l, out var r);
            r.Split(x, out _, out r);
            return Merge(l, r);
        }
    }
}