using System;

namespace DoublyLinkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DoulbyLinkedList<int> _doulbyUnit = new DoulbyLinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                _doulbyUnit.Add(i);
            }
            foreach (var item in _doulbyUnit)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============================================");

            _doulbyUnit.AddFirst(10);
            foreach (var item in _doulbyUnit)
            {
            	Console.WriteLine(item);
            }
            Console.WriteLine("============================================");

            bool temp = _doulbyUnit.Contains(5);
            Console.WriteLine(temp);
            Console.WriteLine("============================================");

            int _count = _doulbyUnit.Count;
            Console.WriteLine(_count);
            Console.WriteLine("============================================");

            bool _isEmpty = _doulbyUnit.IsEmpty;
            Console.WriteLine(_isEmpty);
            Console.WriteLine("============================================");

            _doulbyUnit.Clear();
            bool _isEmpty2 = _doulbyUnit.IsEmpty;
            Console.WriteLine(_isEmpty2);

            Console.ReadLine();
        }
    }
}
