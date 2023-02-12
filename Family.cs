using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Family
    {
        public Family()
        {
            FamilyMembers = new();
        }
        public List<Person> FamilyMembers { get; }
        
        public void AddMember(Person newMember)
        {
            FamilyMembers.Add(newMember);
        }

        public Person GetOldestMember()
        {
            return FamilyMembers.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        
    }
}
