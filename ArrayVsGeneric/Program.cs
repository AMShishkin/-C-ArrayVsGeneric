using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVsGeneric
{
    class Program
    {
        private const int count = 50000000;

        static void Main(string[] args)
        {
            DateTime _dold;

            Console.WriteLine("Массив VS Колеекция");
            _dold = DateTime.Now;

            int[] _myArray = new int[count];

            for (int i = 0; i < count; i++)
                _myArray[i] = 1;

            Console.WriteLine("Массив : " + (DateTime.Now - _dold));

            _dold = DateTime.Now;

            List<int> _myGeneric = new List<int>();

            for (int i = 0; i < count; i++)
                _myGeneric.Add(1);

            Console.WriteLine("Коллекции : " + (DateTime.Now - _dold));

            _dold = DateTime.Now;

            for (int i = 0; i < count; i++)
                _myGeneric[i] = -1;

            Console.WriteLine("Коллекции с заданным капасити : " + (DateTime.Now - _dold));


            Console.ReadKey();


        }
    }
}
