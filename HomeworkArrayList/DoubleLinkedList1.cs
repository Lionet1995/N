using System;
using System.Collections.Generic;
using System.Text;

namespace DoublelinkedList
{
    public class DoubleLinkedList1
    {
        private DoubleNode head;
        private DoubleNode tail;
        private int size;

        public DoubleLinkedList1()
        {

        }

        public DoubleLinkedList1(int[] sourceArray)
        {
            if (sourceArray.Length == 0)
            {
                return;
            }
            else
            {
                head = new DoubleNode(sourceArray[0]);
                size++;
                DoubleNode currentDoubleNode = head;
                tail = head;
                for (int i = 1; i < sourceArray.Length; i++)
                {
                    currentDoubleNode.Next = new DoubleNode(sourceArray[i]);
                    if (size == 1)
                    {
                        currentDoubleNode.Prev = null;
                        tail = currentDoubleNode;
                    }
                    else
                    {
                        currentDoubleNode.Prev = new DoubleNode(sourceArray[i - 2]);
                        tail = currentDoubleNode;
                    }
                    if (i == sourceArray.Length - 1)
                    {
                        tail = currentDoubleNode.Next;
                        tail.Next = null;
                        tail.Prev = currentDoubleNode;
                    }
                    currentDoubleNode = currentDoubleNode.Next;
                    tail = currentDoubleNode;
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

        public void AddFirst(int value)
        {
            DoubleNode DoubleNode = new DoubleNode(value);
            DoubleNode temp = head;
            DoubleNode.Next = temp;
            head = DoubleNode;
            if (size == 0)
                tail = head;
            else
                temp.Prev = DoubleNode;
            size++;
        }

        public void AddFirst(int[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                AddFirst(vals[i]);
            }
        }

        public void AddLast(int value)
        {
            DoubleNode DoubleNode = new DoubleNode(value);

            if (head == null)
            {
                head = DoubleNode;
            }
            else
            {
                tail.Next = DoubleNode;
                DoubleNode.Prev = tail;
            }

            tail = DoubleNode;
            size++;
        }
        public void AddLast(int[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                AddLast(vals[i]);
            }
        }

        public void AddAt(int index, int value)
        {
            DoubleNode DoubleNode = new DoubleNode(value);
            DoubleNode currentDoubleNode = head;
            if ((index < 0) || (index >= size))
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            for (int i = 0; i < index - 1; i++)
            {
                currentDoubleNode = currentDoubleNode.Next;
            }
            DoubleNode.Next = currentDoubleNode.Next;
            DoubleNode.Prev = currentDoubleNode.Prev;
            currentDoubleNode.Next = DoubleNode;
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
                DoubleNode DoubleNode = new DoubleNode(vals[i]);
                DoubleNode currentDoubleNode = head;
                for (int j = 0; j < index - 1; j++)
                {
                    currentDoubleNode = currentDoubleNode.Next;
                }
                DoubleNode.Next = currentDoubleNode.Next;
                DoubleNode.Prev = currentDoubleNode.Prev;
                currentDoubleNode.Next = DoubleNode;
                size++;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new ArgumentNullException("NullElements");
            }
            else if (size == 1)
            {
                size--;
                head = head.Next;
                tail = head;
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
            else if (size == 1)
            {
                size--;
                head = head.Prev;
                tail = head;
            }
            else
            {
                tail = tail.Prev;
                tail.Next = null;
                size--;
            }
        }

        public void RemoveAt(int index)
        {
            if (head == null || index < 0 || index > size)
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
                DoubleNode currentDoubleNode = head;

                for (int i = 0; i < index - 1; i++)
                {
                    currentDoubleNode = currentDoubleNode.Next;
                }
                currentDoubleNode.Next = currentDoubleNode.Next.Next;
                size--;
            }
        }


        public int[] ToArray()
        {
            int[] arr = new int[size];

            DoubleNode currentDoubleNode = head;
            int currentIndex = 0;
            while (currentDoubleNode != null)
            {
                arr[currentIndex] = currentDoubleNode.Value;
                currentDoubleNode = currentDoubleNode.Next;
                currentIndex++;
            }
            return arr;
        }

        public int GetFirst()
        {
            if (head == null)
            {
                throw new ArgumentOutOfRangeException("There are no elements in list");
            }
            else
            {
                return head.Value;
            }
        }

        public int GetLast()
        {
            if (head == null)
            {
                throw new ArgumentOutOfRangeException("There are no elements in list");
            }
            else
            {
                return tail.Value;
            }
        }

        public void Set(int index, int val)
        {
            DoubleNode DoubleNode = new DoubleNode(val);

            if (index == 0)
            {
                head.Value = DoubleNode.Value;
            }
            else
            {
                DoubleNode currentDoubleNode = head;
                for (int i = 0; i < size; i++)
                {
                    if (i == index)
                    {
                        currentDoubleNode.Value = DoubleNode.Value;
                    }

                    currentDoubleNode = currentDoubleNode.Next;
                }
            }
        }

        public int Get(int index)
        {
            DoubleNode currentDoubleNode = head;

            if ((index < 0) || (index >= size))
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            else if (index == 0)
            {
                return currentDoubleNode.Value;
            }
            else
            {
                for (int i = 0; i < size; i++)
                {

                    if (i == index)
                    {
                        return currentDoubleNode.Value;
                    }

                    currentDoubleNode = currentDoubleNode.Next;
                }
                return -1;
            }
        }

        public void Reverse()
        {
            DoubleNode currentDoubleNode = head;
            while (currentDoubleNode.Next != null)
            {
                DoubleNode nextDoubleNode = currentDoubleNode.Next;
                currentDoubleNode.Next = nextDoubleNode.Next;
                nextDoubleNode.Next = head;
                head = nextDoubleNode;
                tail = currentDoubleNode;
            }

        }

        public bool Contains(int value)
        {
            DoubleNode DoubleNode = new DoubleNode(value);
            DoubleNode currentDoubleNode = head;
            if (head == null)
            {
                return false;
            }
            while (currentDoubleNode != null)
            {
                if (currentDoubleNode.Value == DoubleNode.Value)
                {
                    return true;
                }
                currentDoubleNode = currentDoubleNode.Next;
            }
            return false;
        }

        public int IndexOf(int value)
        {
            if (head == null)
            {
                throw new ArgumentOutOfRangeException("");
            }
            else
            {
                DoubleNode currentDoubleNode = head;
                for (int i = 0; i < size; i++)
                {
                    if (currentDoubleNode.Value == value)
                    {
                        return i;
                    }
                    currentDoubleNode = currentDoubleNode.Next;
                }
                return -1;
            }
        }



    }
}

