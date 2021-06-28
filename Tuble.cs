using System;

namespace Tuple
{
    class Tuple
    {


        static void Main(string[] args)
        {
            var bill = Tuple.Create(1, "Bill", "Gates");

            var person = GetPerson();
            Console.WriteLine(person);
            (int id, string fn, string ln) = person;
            Console.Write(id + "");
            Console.Write(fn + "");
            Console.Write(ln + "");


        }
        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Bill", "Gates");
        }

    }
}

