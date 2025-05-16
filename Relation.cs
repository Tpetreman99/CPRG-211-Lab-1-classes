using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Relation
    {
        public string RelationshipType;
        public void ShowRelationship(Person person1, Person person2)
        {
            if(person1.firstName=="Gina" && person2.firstName == "Mary") 
            {
                RelationshipType = "SisterHood";
            }
            else if(person1.firstName=="Ian" && person2.firstName == "Mike")
            {
                RelationshipType = "BrotherHood";
            }
        }
    }
}
