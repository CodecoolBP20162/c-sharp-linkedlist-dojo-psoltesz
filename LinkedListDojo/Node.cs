using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    class Node<T>
    {
        public T Content;
        public Node<T> Next;

        public Node(T content)
        {
            Content = content;
            Next = null;
        }

        public override string ToString()
        {
            return Content.ToString();
        }
    }
}
