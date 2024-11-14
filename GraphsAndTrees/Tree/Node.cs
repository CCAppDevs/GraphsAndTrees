using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTrees.Tree
{
    public class Node<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public static int CheckCount { get; set; }

        public bool HasValue(T check)
        {
            CheckCount++;

            // base case
            if (check.CompareTo(Value) == 0)
            {
                return true;
            }

            if (check.CompareTo(Value) < 0)
            {
                if (Left == null)
                {
                    return false;
                }
                else
                {
                    return Left.HasValue(check);
                }
            }
            else
            {
                if (Right == null)
                {
                    return false;
                }
                else
                {
                    return Right.HasValue(check);
                }
            }
        }

        public void Add(T value)
        {
            if (value.CompareTo(Value) < 0)
            {
                if (Left == null)
                {
                    Left = new Node<T>(value);
                }
                else
                {
                    Left.Add(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new Node<T>(value);
                }
                else
                {
                    Right.Add(value);
                }
            }
        }
    }
}
