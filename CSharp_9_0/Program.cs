using CSharp_9_0._4장;
using System;

namespace CSharp_9_0
{
    internal class Program
    {
        static bool AscSort(object arg1, object arg2)
        {
            Person person1 = arg1 as Person;    // 대상 타입으로 형변환
            Person person2 = arg2 as Person;

            return person1.Age.CompareTo(person2.Age) < 0;
        }

        static bool DesSort(object arg1, object arg2)
        {
            Person person1 = arg1 as Person;    // 대상 타입으로 형변환
            Person person2 = arg2 as Person;

            return person1.Age.CompareTo(person2.Age) > 0;
        }


        static void Main(string[] args)
        {
            Person[] person = new Person[]
           {
                new Person(51, "Anders"),
                new Person(37, "Scott"),
                new Person(45, "Peter"),
                new Person(62, "Mads"),
           };

            SortObject so = new SortObject(person);
            so.Sort(AscSort);
            so.Display();
            so.Sort(DesSort);
            so.Display();
        }
    }
}
