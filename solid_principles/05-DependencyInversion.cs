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

    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    // low-level parts of the system
    public class Relationships
    {
        private List<(Person, Relationship, Person)> relations 
        = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Parent, parent));
        }

        // public List<(Person, Relationship, Person)> Relations => relations;
    }

    public class Search
    {
        // public Search(Relationships relationships)
        // {
        //     var relations = relationships.Relations;
        //     foreach (var r in relations.Where(
        //         x => x.Item1.Name == "John" &&
        //              x.Item2 == Relationship.Parent
        //     ))
        //     {
        //         WriteLine($"John has a child called {r.Item3.Name}");
        //     }
        // }

        static void Main(string[] args)
        {
            var parent = new Person() {Name = "John"};
            var child1 = new Person() {Name = "Chris"};
            var child2 = new Person() {Name = "Mary"};

            var relationships = new Relationship();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Search(relationships);
        }
    }
}