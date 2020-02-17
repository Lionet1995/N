using System;
using System.Text;

namespace LinkedList1
{
    public class LinkedList
    {
        private Node head;
        private int size;

        public LinkedList()
        {

        }

        public LinkedList(int[] sourceArray)
        {
            if (sourceArray.Length == 0)
            {
                return;
            }
            else
            {
                head = new Node(sourceArray[0]);
                size++;
                Node currentNode = head;
                for (int i = 1; i < sourceArray.Length; i++)
                {
                    currentNode.Next = new Node(sourceArray[i]);
                    currentNode = currentNode.Next;
                    size++;
                }
            }
        }

        public bool Empty
        {
            get { return this.size == 0; }
        }
        public int GetSize
        {
            get { return this.size; }
        }

        public void AddFirst(int val)
        {
            Node node = new Node(val);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.Next = head;
                head = node;
            }
            size++;
        }
        public void AddFirst(int[] vals)
        {
            if (head == null)
            {
                Node node = new Node(vals[0]);
                head = node;
                size++;
                for (int i = 1; i < vals.Length; i++)
                {
                    Node node1 = new Node(vals[i]);
                    node1.Next = head;
                    head = node1;
                    size++;
                }
            }
            else
            {
                for (int i = 0; i < vals.Length; i++)
                {
                    Node node = new Node(vals[i]);
                    node.Next = head;
                    head = node;
                    size++;
                }
            }
        }

        public void AddLast(int val)
        {
            Node node = new Node(val);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node last = GetLast();
                last.Next = node;
                size++;
            }
        }

        public void AddLast(int[] vals)
        {
            if (head == null)
            {
                Node node = new Node(vals[0]);
                head = node;
                size++;
            }
            else
            {
                Node last = GetLast();
                for (int i = 0; i < vals.Length; i++)
                {
                    Node node = new Node(vals[i]);
                    last.Next = node;
                    size++;
                    last = last.Next;
                }
            }
        }
        public void Set(int index, int val)
        {
            Node node = new Node(val);

            if (index == 0)
            {
                head.Value = node.Value;
            }
            else
            {
                Node currentNode = head;
                for (int i = 0; i < size; i++)
                {
                    if (i == index)
                    {
                        currentNode.Value = node.Value;
                    }

                    currentNode = currentNode.Next;
                }
            }
        }

        public void AddAt(int index, int value)
        {
            Node node = new Node(value);
            Node currentNode = head;
            if ((index < 0) || (index >= size))
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            for (int i = 0; i < index - 1; i++)
            {
                currentNode = currentNode.Next;
            }
            node.Next = currentNode.Next;
            currentNode.Next = node;
            size++;

        }

        public void AddAt(int index, int[] vals)
        {
            if ((index < 0) || (index > size))
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            for (int i = 0; i < vals.Length; i++)
            {
                Node Node = new Node(vals[i]);
                Node currentnode = head;
                for (int j = 0; j < index - 1; j++)
                {
                    currentnode = currentnode.Next;
                }
                Node.Next = currentnode.Next;
                currentnode.Next = Node;
                size++;
            }

        }

        public Node GetFirst()
        {
            Node currentnode = head;
            if (head == null)
                return null;

            else
                return currentnode;
        }

        public Node GetLast()
        {
            if (head == null)
                return head;
            Node currentnode = head;
            while (currentnode.Next != null)
            {
                currentnode = currentnode.Next;
            }

            return currentnode;
        }

        public int Get(int index)
        {
            Node currentnode = head;
            Node node = new Node(index);

            if ((index < 0) || (index >= size))
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            else if (index == 0)
            {
                return currentnode.Value;
            }
            else
            {
                for (int i = 0; i < size; i++)
                {

                    if (i == index)
                    {
                        return currentnode.Value;
                    }

                    currentnode = currentnode.Next;
                }
                return -1;
            }
        }
        public bool Contains(int val)
        {
            Node node = new Node(val);
            Node currentnode = head;
            if (head == null)
            {
                return false;
            }
            while (currentnode != null)
            {
                if (currentnode.Value == node.Value)
                {
                    return true;
                }
                currentnode = currentnode.Next;
            }
            return false;
        }

        public int IndexOf(int val)
        {
            Node node = new Node(val);
            Node currentnode = head;

            while (currentnode != null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (currentnode.Value.Equals(node.Value))
                    {
                        return i;
                    }
                    currentnode = currentnode.Next;
                }
            }
            return -1;

        }

        public int[] ToArray()
        {
            if (size == 0)
            {
                return new int[] { };
            }
            else
            {
                int[] result = new int[size];
                Node nextNode = head;
                for (int i = 0; i < size; i++)
                {
                    result[i] = nextNode.Value;
                    nextNode = nextNode.Next;
                }

                return result;
            }

        }

        public void Reverse()
        {
            Node currentNode = head;
            while (currentNode.Next != null)
            {
                Node nextNode = currentNode.Next;
                currentNode.Next = nextNode.Next;
                nextNode.Next = head;
                head = nextNode;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new ArgumentNullException("NullElements");
            }
            else
            {
                size--;
                head = head.Next;
            }
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                throw new ArgumentNullException("NullElements");
            }
            else
            {
                Node currentNode = head;
                for (int i = 0; i < size - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = null;
                size--;
            }
        }

        public void RemoveAt(int index)
        {
            if (head == null)
            {
                throw new ArgumentNullException("NullElements");
            }
            if (index == 0)
            {
                size--;
                head = head.Next;
            }
            else
            {
                Node currentNode = head;

                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = currentNode.Next.Next;
                size--;

            }
        }
    }

}
