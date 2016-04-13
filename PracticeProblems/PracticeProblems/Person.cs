using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public DateTime birthday;

        public Person(DateTime Birthday)
        {
            //DateTime today = DateTime.Today;
            //age = today.Year - person.birthday.Year;
            birthday = Birthday;
        }

        public static Person operator +(Person person, int Age)
        {
            //Person newPerson = new Person(new DateTime(1971, 02, 11));
            DateTime today = DateTime.Today;
            person.age = today.Year - person.birthday.Year;
            person.age += Age;         
            return person;
        }

        /*
       Overload Operator
       -    Problem 1: Create a person class that has a first name, last name, age, and birthday. The Person constructor should take in
       a birthday.  Overload the plus (+) operator to take in a Person and integer and return a Person. The returned Person should
       display what age they will be 12 years later. 
       */
    }
}
