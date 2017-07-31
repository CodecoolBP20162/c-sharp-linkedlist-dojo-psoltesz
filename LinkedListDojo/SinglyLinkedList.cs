using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    public class SinglyLinkedList<T>
    {
        Node<T> Head { get; set; }

        public SinglyLinkedList()
        {
            Head = null;
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Head == null)
            {
                Head = newNode;
            } else
            {
                Node<T> last = GetNode(-1);
                last.Next = newNode;
            }
        }

        public void Insert(T item, int index)
        {
            index--;
            if (index == -1)
            {
                Node<T> newHead = new Node<T>(item);
                newHead.Next = Head;
                Head = newHead;
                return;
            }
            Node<T> currentNode = GetNode(index);
            Node<T> newNode = new Node<T>(item);
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
        }

        public void Remove(int index)
        {
            if (index == 0)
            {
                Head = Head.Next;
                return;
            }

            Node<T> currentNode = Head;
            int counter = 0;
            while (counter < index - 1)
            {
                currentNode = currentNode.Next;
                ++counter;

                if (currentNode.Next == null)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
            }
            currentNode.Next = currentNode.Next.Next;
        }

        private Node<T> GetNode(int index)
        {
            Node<T> currentNode = Head;
            if (index == 0)
            {
                return currentNode;
            }
            int counter = 0;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                ++counter;

                if (index != -1 && counter == index)
                {
                    break;
                }
            }
            return currentNode;
        }

        public override string ToString()
        {
            Node<T> currentNode = Head;
            string result = currentNode.ToString();
            do
            {
                currentNode = currentNode.Next;
                result += ", " + currentNode.ToString();
            } while (currentNode.Next != null);

            return result;
        }
    }
}
