using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesList
{
    class Program
    {
        struct Human
        {
            public string Name;
            public int Age;
        }
        static void ReplaceElement(string[] array, int _number, string _item)
        {
            array[_number] = _item;
            PrintArray(array);
        }
        static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            
            Human[] human = new Human[2];
            human[0].Name = "Билл";
            human[0].Age =Convert.ToInt32(Console.ReadLine());
            string[] Guests = new string[] { "Боб", "Том", "Джон", "Джоан", "Джастин", "Тед" };
            bool Flag = Guests.Length % 2 == 0;
            
            PrintArray(Guests);
            string match = Console.ReadLine();
            foreach (var item in Guests)
            {
                if (item == match)
                {
                    Console.WriteLine("Имя {0} входит!", match);
                }
            }
            for (int i = 0; i < Guests.Length; i++)
            {
                if (Guests[i] == match)
                    
                {
                    
                    Console.WriteLine("Имя {0} входит, имеет номер {1}", match, i,"hi");
                }
            }
            ReplaceElement(Guests, 1,Convert.ToString(human[0].Age));
            PrintArray(Guests);

           
            Console.WriteLine();
        }
    }
}

