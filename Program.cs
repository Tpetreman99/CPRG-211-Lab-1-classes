using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objects of person class
            Person obj1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person obj2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person obj3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person obj4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //Display Ginas informaiton as a scentance
            obj2.DisplayPersonInfo();

            //Displaying Person 3s info as string
            Console.WriteLine(obj3.ToString());

            //Change Ians favourite colour
            obj1.ChangeFavouriteColour("White");
            obj1.DisplayPersonInfo();

            //Displays mary's age in ten years
            int ageintenyears = obj4.GetAgeInTenYears();
            Console.WriteLine($"{obj4.firstName} {obj4.lastName} Age in 10 years is: {ageintenyears}");

            //Relation calss object created
            Relation rel_obj1=new Relation();
            Relation rel_obj2=new Relation();

            rel_obj1.ShowRelationship(obj2, obj4 );
            rel_obj2.ShowRelationship(obj1, obj3);

            Console.WriteLine($"Relationship between {obj2.firstName} and {obj4.firstName} is: {rel_obj1.RelationshipType}");
            Console.WriteLine($"Relationship between {obj1.firstName} and {obj3.firstName} is: {rel_obj2.RelationshipType}");


            //Create a list of the objects of the Person calss
            List<Person> listperson = new List<Person>() { obj1, obj2, obj3, obj4 };

            //Showing average age of all people i the list
            double averageAge(List<Person> people)
            {
                double total = 0;
                foreach (Person person in people)
                {
                    total = total + Convert.ToDouble(person.age);
                }
                return total / people.Count;
            }
            Console.WriteLine($"Average age is: {averageAge(listperson)}");

            //show the youngest person and the oldest person
            string YoungestAndOldestPerson(List<Person> people)
            {
                Person youngestPerson = people.OrderBy(p => p.age).First();
                Person oldesterson = people.OrderByDescending(p => p.age).First();

                return $"The youngest person is {youngestPerson.firstName}\n" +
                       $"The oldest person is {oldesterson.firstName}";
            }

            Console.WriteLine(YoungestAndOldestPerson(listperson));

            //show the names of people whos name starts with M  
            void NameStartsWithM(List<Person> people)
            {
                List<string> namesThatStartWithM = new List<string>();

                foreach (Person person in people)
                {
                    if (person.firstName.StartsWith("M"))
                    {
                        Console.WriteLine(person.ToString());
                    }
                }        
            }
            NameStartsWithM(listperson);
            
            //showing the person that likes the colour blue
            Person favouriteColourBlue = listperson.FirstOrDefault(p => p.favoriteColour == "Blue");
            Console.WriteLine(favouriteColourBlue.ToString());
        }
    }
}
