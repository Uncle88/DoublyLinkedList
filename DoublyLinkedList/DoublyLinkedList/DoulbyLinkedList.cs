using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DoulbyLinkedList<T> : IEnumerable<T>
    {
        public DoulbyUnit<T> head;
        public DoulbyUnit<T> tail;
        int count;

        public void Add(T data)
        {
            DoulbyUnit<T> _doulbyUnit = new DoulbyUnit<T>(data);
            if (head == null)
               head = _doulbyUnit;
            else
            {
                tail.Next = _doulbyUnit;
                tail.Previous = tail;
            }
            tail = _doulbyUnit;
            count++;
        }
 
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
