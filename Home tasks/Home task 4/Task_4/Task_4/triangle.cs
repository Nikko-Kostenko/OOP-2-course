using System;

namespace Task_4
{
    public class Triangle
    {
        private int Side1 { get; set; }
        private int Side2 { get; set; }
        private int Side3 { get; set; }

        public void ChangeSideValue(int caseSwitch, int value) // caseSwitch - number of a side (1 - 3) 
        {
          
            if (value > 0)
            {
                switch (caseSwitch)
                {
                    case 1:
                        if ((value + Side2 > Side3) & (value + Side3 > Side2) & (Side2 + Side3 > value))
                        {
                            Side1 = value;
                        }
                        break;
                    case 2:
                        if ((Side1 + value > Side3) & (Side1 + Side3 >value) & (value + Side3 > Side1))
                        {
                            Side1 = value;
                        }
                        break;
                    case 3:
                        if ((Side1 + Side2 > value) & (Side1 + value > Side2) & (Side2 + value > Side1))
                        {
                            Side1 = value;
                        }
                        break;
                    default:
                        Console.WriteLine("unknown side");
                        break;
                }
            }
        }

        public double GetAngle(int A, int B, int C)
        {
            return Math.Acos( ( Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2) ) / 2 * A * B);
        }

        public void GetChoosedAngle(int caseSwitch)
        {
            switch (GetHashCode())
            {
                case 1:
                    Console.WriteLine(GetAngle(Side3, Side2, Side1));
                    break;
                case 2:
                    Console.WriteLine(GetAngle(Side3, Side1, Side2));
                    break;
                case 3:
                    Console.WriteLine(GetAngle(Side1, Side2, Side3));
                    break;
                default:
                    Console.WriteLine("angle not found");
                    break;
            }
        }

        public void GetSideSum()
        {
            Console.WriteLine(Side1 + Side2 + Side3);
        }
    }
}