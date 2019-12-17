using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }

    public class Person
    {
        public string Name;
        // public string Lastname;
        // public DateTime DateOfBirth;
    }

    // low-level parts of the system
    public class Relationships
    {
        private List<(Person, Relationship, Person)> relations 
        = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            
        }
    }
}