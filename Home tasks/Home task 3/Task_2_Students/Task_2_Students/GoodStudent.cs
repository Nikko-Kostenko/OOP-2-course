using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_Students
{
    class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {}

        public override void study()
        {   
            read();//in me opinion, good student needs to read lecture before lessons and relax!
            relax();
            write();
            relax();
            write();
            relax();
            write();
        }

        public override void relax()
        {
            actions += " walk outside ";
        }
    }
}
