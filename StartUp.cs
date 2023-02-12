using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)

        {
            // ******* THIS IS THE INPUT FOR TASK #3******//
        //    Family family = new Family();
        //    int n = int.Parse(Console.ReadLine());
        //    for(int i = 0; i < n; i++)
        //    {
        //        string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //        Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
        //        family.AddMember(person);
        //    }
        //    Console.WriteLine(family.GetOldestMember().ToString());

            //INPUT FOR TASK #4//
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                family.AddMember(person);
            }
            
            foreach(Person p in family.FamilyMembers.Where(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
        }
    }
}
