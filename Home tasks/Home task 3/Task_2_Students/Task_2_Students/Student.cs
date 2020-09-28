using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_Students
{
    abstract class Student //I use a abstract class cause I need to define each type of students in a different way
    {
        //incapsulated variables------------------------------------------------------------------------------------------------------
        protected string name;
        protected string actions;

        //variable properties---------------------------------------------------------------------------------------------------------
        public string Name
        {
            get { return name; }
        }

        public string Actions
        {
            get { return actions; }
        }
        //constructor------------------------------------------------------------------------------------------------------------------
        public Student(string _name)
        {
            name = _name;
        }
        //Class Methods----------------------------------------------------------------------------------------------------------------
        //Study method NEEDS to be declared in a children classes, so I use abstract
        public abstract void study();

        //Read, write and relax methods in most cases are the same, so we use virtual, but i prefer to use abstract with method relax

        public abstract void relax();

        public virtual void read()
        {
            actions += " read ";
        }

        public virtual void write()
        {
            actions += " write ";
        }
    }
}
