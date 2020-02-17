using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkArrayList
{
    public class ArrayList
    {
        private int realLength;
        private int[] array;

        public ArrayList()
        {
            array = new int[10];
            realLength = 0;
        }

        public void Add(int val)
        {
            if (realLength == array.Length)
            {
                EnlargeArray();
            }
            array[realLength] = val;
            realLength++;


        }

        public void Add(int index, int val)
        {
            if (realLength == array.Length)
            {
                EnlargeArray();
            }
            array[index] = val;
            realLength++;
        }

        public void Set(int index, int val)
        {
            array[index] = val;
        }

        public int[] GetArray()
        {
            int[] array1 = array;
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == 0)
                {
                    break;
                }
                array1[i] = array[i];
                Console.WriteLine(array1[i]);
            }
            return array1;

        }

        public int Get(int index)
        {
            for (int i = 0; i < realLength; i++)
            {
                if (i == index)
                {
                    return array[index];
                }

            }
            return -1;

        }

        public void Remove(int val)
        {
            int index = Array.IndexOf(array, val, 0, realLength);

            if (index < 0)
            {
                return;
            }
            for (int i = index; i < realLength - 1; i++)
            {
                if (i == realLength - 2)
                {
                    array[i] = array[i + 1];
                    array[i + 1] = 0;

                }
                else
                    array[i] = array[i + 1];
            }
            realLength--;
        }

        public void RemoveAll(int val)
        {
            for (int i = 0; i < realLength - 1; i++)
            {
                if (array[i] == val)
                {
                    for (int j = i; j < realLength - 1; j++)
                    {
                        if (j == realLength - 2)
                        {
                            array[j] = array[j + 1];
                            array[j + 1] = 0;

                        }
                        else
                            array[j] = array[j + 1];
                    }
                    realLength--;
                }
            }

        }

        public void RemoveIdx(int index)
        {
            for (int i = index; i < realLength - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[realLength - 1] = 0;
            realLength--;
        }

        public int Size()
        {
            return realLength;

        }

        public bool Contains(int val)
        {
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == val)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(int val)
        {
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }
        public void EnlargeArray()
        {
            int[] temp = new int[(array.Length * 3 / 2) + 1];
            for (int i = 0; i < realLength - 1; i++)
            {
                temp[i] = array[i];
            }
            array = temp;
        }
        public void EnlargeArray(int[] array)
        {
            int newLength = array.Length + (this.array.Length * 3) / 2 + 1;
            int[] temp = new int[newLength];
            for (int i = 0; i < this.array.Length; i++)
            {
                temp[i] = this.array[i];
            }
            this.array = temp;
        }

        public void AddAll(int[] array)
        {
            if (array.Length > this.array.Length - realLength)
            {
                EnlargeArray();
                //  int newLength = array.Length + (this.array.Length * 3) / 2 + 1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Add(array[i]);
            }
        }

        public void AddAll(int[] array, int index)
        {
            if (array.Length > this.array.Length - realLength)
            {
                EnlargeArray();
                //  int newLength = array.Length + (this.array.Length * 3) / 2 + 1;
            }
            for (int i = index; i < array.Length; i++)
            {
                realLength = i;
                Add(array[realLength]);
            }

        }

        public int[] Search(int val)
        {
            int j = 0;
            int count = 0;
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == val)
                {
                    count++;
                }
                if (array[realLength - 1] == val)
                    count++;
            }
            int[] arr = new int[count];
            for (int i = 0; i < realLength; i++)
            {
                if (array[i] == val)
                {
                    arr[j] = i;
                    j++;
                }
                if (array[realLength - 1] == val)
                {
                    arr[j] = realLength - 1;
                    j++;
                }
            }
            return arr;

        }

    }
}

