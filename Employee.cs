using System;
using System.Collections.Generic;

namespace bangazon
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;

        public string Name {get {return _firstName + " " + _lastName;}}

        public Employee(string firstName, string lastName) 
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        List<string> closeRestaurants = new List<string>
        {
            "Smokin Thighs",
            "Clawsons Deli",
            "ML Rose",
            "Red Bicycle",
            "Las Palmas"
        };

        public string eat() 
        {
            // create random number between 0 and the amount of restaurants in the list of close Restaurants
            int rNum = new Random().Next(0, closeRestaurants.Count); 

            // if there are restaurants listed in close restaurants, use the random number to pick one and return it
            if (closeRestaurants.Count > 0) {
                Console.WriteLine($"{_firstName} is at {closeRestaurants[rNum]}.");
                return closeRestaurants[rNum];
            } else {
                return "No available restaurants";
            }
        }

        // overload the eat method to take a parameter of what food the employee is eating at the office
        public string eat(string food)
        {
            Console.WriteLine($"{_firstName} ate {food} at the office.");
            return _firstName + "ate food at the office.";
        } 

        // overload the eat method again
        public void eat(List<Employee> companions)
        {
            // create random number between 0 and the amount of restaurants in the list of close Restaurants
            int rNum = new Random().Next(0, closeRestaurants.Count); 

            // if there are restaurants listed in close restaurants, use the random number to pick one and return it.
            // iterate through the passed in companions list and include 
            if (closeRestaurants.Count > 0) {
                Console.Write($"{_firstName} is at {closeRestaurants[rNum]} ");
                Console.Write($"with ");

                foreach (Employee c in companions)
                {
                    Console.Write($"{c._firstName}, ");
                }
            }
        }

        public void eat(string food, List<Employee> companions)
        {
            // create random number between 0 and the amount of restaurants in the list of close Restaurants
            int rNum = new Random().Next(0, closeRestaurants.Count); 

            // if there are restaurants listed in close restaurants, use the random number to pick one and return it
            if (closeRestaurants.Count > 0) {
                Console.WriteLine();
                Console.Write($"{_firstName} is at {closeRestaurants[rNum]} eating {food} ");
                Console.Write($"with ");

                foreach (Employee c in companions)
                {
                    Console.Write($"{c._firstName}, ");
                }
            }
        }

        // override the default ToString method to return the name of the employee
        public override string ToString() 
        {
            return $"{Name}";
        }


    }
}