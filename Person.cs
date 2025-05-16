using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person

    {
        //data members
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;
        //Constructor
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void ChangeFavouriteColour(string favoriteColour)
        {
            this.favoriteColour = favoriteColour;
        }

        public int GetAgeInTenYears()
        {
            return age + 10;
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{personId}: {firstName} {lastName}'s favourite colour is: {favoriteColour}");
        }
        public override string ToString()
        {
            return $"PersonID: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavouriteColour: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}";
        }

    }
}
