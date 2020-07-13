using System;
namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        private static int nextId = 1; // static value does not get stored in any specific instance, but instead with the class definition
        public string Value { get; set; }

        public Employer() //Iterates the IDs whenever Employer is instanced
        {
            Id = nextId;
            nextId++;
        }

        public Employer(string value) : this() //Sets the value (in this case, employer name).  What is the this() doing again?  Makes initializing the ID be a default behavior.  This technique is called Constructor Chaining.
        {
            Value = value;
        }

        public override bool Equals(object obj) //Tests equivalence on the ID
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString() //Outputs the string value (name)
        {
            return Value;
        }
    }
}
