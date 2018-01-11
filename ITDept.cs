using System;
using System.Collections.Generic;

namespace bangazon
{
    /*
        Class for representing Human Resources department.

        It is very important to note here that since HumanResources
        inherits from the Department type, any object instance
        is both of type HumanResources AND Department.

        Remember, inheritance denotes an is-a relationship.
    */
    public class ITDept : Department
    {
        /*
            Now this syntax looks very strange! What's going on here?
            To relate back to your JavaScript knowledge, this code
            is creating an array that holds objects.

            The keywords are telling the compiler that each item in 
            the List will have a key of type string, and a value of 
            type string.

            For example, it would look like this in JavaScript.
            [{'vacation':'Unlimited vacation for everyone!!'}]
        */
        private Dictionary<string, string> _computers = new Dictionary<string, string>();

        private string meetingRoom = "Dark Basement Room";
        /*
            Since the parent class defined a constructor with three
            arguments, the derived class must also define a constructor
            with the same signature, or arity, as the parent.

            Then, we can just pass those argument values directly to the
            parent class with the `base` keyword.
        */
        public ITDept(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        {
        }

        // Publicly accessible method to add an IT computer
        public void AddComputer(string title, string location)
        {
            /*
                Talk about verbose! Every time you want to create, or
                reference a KeyValuePair, you have to use the angle
                brackets, and type keywords.
            */
            _computers.Add(title, location);

        }

        public void ListComputers()
        {
            foreach (KeyValuePair<string, string> computer in _computers)
            {
                Console.WriteLine($"{computer.Value}");
            }
        }

        public override void meet(DateTime date)
        {
            DateTime Date = date;
            Console.WriteLine($"New meeting in the {meetingRoom} at {Date}.");

        }
    }
}