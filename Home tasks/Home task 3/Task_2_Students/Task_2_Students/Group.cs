using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_Students
{
    class Group
    {
        private string groupName;
        List<Student> students = new List<Student>();

        public Group(string _groupName, params  Student[] __student)
        {
            groupName = _groupName;

            foreach (Student _student in __student)
            {
                this.students.Add(_student);
            }
        }

        public void Student_info()
        {
            foreach (Student st in students)
            {
                Console.WriteLine(st.Name);
            }
        }

        public void Student_full_info()
        {
            foreach (Student st in students)
            {
                Console.WriteLine(st.Name + " " + st.Actions);
            }
        }

        public void Lesson()
        {
            foreach (Student st in students )
            {
             st.study();   
            }
        }
    }
}
