using System;
using System.Collections.Generic;
using System.Text;

namespace DoublelinkedList
{
    public class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode Prev { get; set; }

        public DoubleNode(int value)
        {
            Value = value;
        }
    }
}
