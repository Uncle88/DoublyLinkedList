using System;
namespace DoublyLinkedList
{
    public class DoulbyUnit<T>
    {
        public DoulbyUnit(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public DoulbyUnit<T> Previous { get; set; }
        public DoulbyUnit<T> Next { get; set; }
    }
}
