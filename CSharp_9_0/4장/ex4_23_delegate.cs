using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 델리게이트와 object를 이용한 범용 정렬 코드
namespace CSharp_9_0._4장
{
    delegate bool CompareDelegate(object arg1, object arg2);

    class Person
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name + ": " + Age;
        }
    }
    class SortObject
    {
        object[] things;

        public SortObject(object[] things)  // object 배열
        {
            this.things = things;
        }

        public void Sort(CompareDelegate compareMethod)
        {
            object temp;

            for (int i = 0; i < this.things.Length; i++)
            {
                int lowPos = i;

                for (int j = i + 1; j < things.Length; j++)
                {
                    if (compareMethod(things[j], things[lowPos]))
                    {
                        lowPos = j;
                    }
                }

                temp = things[lowPos];
                things[lowPos] = things[i];
                things[i] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine(things[i] + ",");
            }
        }
    }
}
