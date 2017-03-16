﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 abstract = can be inherited not instantiated
 sealed = can not be inherited
 virtual = can be overwritten 
*/
namespace Mod06Demo02
{
    public abstract class Person:IComparable<Person> /*Base Class, can be defined as sealed, abstract and virtual, Icomparable is to sort Person member by name alphabetically */
    {
        protected static int nextID = 1;//field should be changed from private to protected to be able to inherite to other classes 
        public Person()
        {
            // default Custome constructor
            ID = nextID++;
            Notes = "this is a sample note";
        }
        public int ID { get; set; } // property
        public string Name { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public virtual string Details()/* Method must have return, virtual type is to be able to overwrite by class that is inheritted to this base class*/
        {
            return string.Format("Person {0}\n{1}\n{2}\n{3}", ID, Name, Email,Notes.TitleCase());// TitleCase is Extention method that we create it in Utilities
        }

        public int CompareTo(Person other)// Auto generated by right click and implemet implicity of IComparable<Person> interface. 
        {
            return Name.CompareTo(other.Name);// because we have compare here, we need to implement sort in utility
        }
    }
}
