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

        public bool Remove(T data)
        {
            DoulbyUnit<T> actual = head;
            DoulbyUnit<T> prior = null;

            //search element for delete
            while (actual != null)
            {
                if (actual.Data.Equals(data))
                {
                    break;
                }
                actual = actual.Next;
            }
            if (actual != null)
            {
                //if element not last
                if (actual.Next != null)
                {
                    actual.Next.Previous = actual.Previous;
                }
                else
                {
                    //if element last
                    tail = actual.Previous;
                }

                //if element not first
                if (actual.Previous != null)
                {
                    actual.Previous.Next = actual.Next;
                }
                else
                {
                    //if - first
                    head = actual.Next;
                }

                count--;
                return true;
            }
            return false;
        }

        public int Count { get { return count; }}
 
        public bool IsEmpty
        {
            get
            {
                if (count == 0)
                    return true;
                return false;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
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
