using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_Students
{
    class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {}

        public override void study()
        {
            relax();
            relax();
            relax();
            read();
            relax();
            relax();
        }

        public override void relax()
        {
            actions += " sleep ";
        }
    }
}
