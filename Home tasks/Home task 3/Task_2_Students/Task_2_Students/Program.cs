using System;
using System.Dynamic;

namespace Task_2_Students
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BadStudent Nikko = new BadStudent("Николас");
            GoodStudent Artem = new GoodStudent("Artemi");
            GoodStudent Hella = new GoodStudent("Hella");
            Group k26 = new Group("k26", Nikko, Artem, Hella);
            k26.Student_info();

            k26.Lesson();

            k26.Student_full_info();
        }

    }
}