//Employee.cs
using System;

namespace OperatorOverloadAssignment
{
    //Define the Employee class
    public class Employee
    {
        //Property to store the employee ID
        public int Id { get; set; }

        //Property to store the employee's first name
        public string FirstName { get; set; }

        //Property to store the employee's last name
        public string LastName { get; set; }

        //Overload the == operator so two Employee objects can be compared
        //This method checks if the Id values of two employees are equal
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            //Check if both objects are null
            if (ReferenceEquals(emp1, emp2))
                return true;

            //Check if either object is null
            if (emp1 is null || emp2 is null)
                return false;

            //Return true if both employee Id values are the same
            return emp1.Id == emp2.Id;
        }

        //Overload the != operator (required pair for ==)
        //This returns true if the employee Id values are NOT equal
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            //Return the opposite result of the == operator
            return !(emp1 == emp2);
        }

        //Override Equals method to match operator overload behavior
        public override bool Equals(object obj)
        {
            //Check if the object is an Employee
            if (obj is Employee other)
            {
                //Compare employee Id values
                return this.Id == other.Id;
            }
            return false;
        }

        //Override GetHashCode because Equals was overridden
        public override int GetHashCode()
        {
            //Return the hash code of the Id property
            return Id.GetHashCode();
        }
    }
}
