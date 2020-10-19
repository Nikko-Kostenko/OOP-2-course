using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

/* 
This is a mixed parser which uses reverse polish notation to calculate expressions 
*/
namespace LabCalc1
{

    class Rpn
    {
        private const string EROR_TOO_MANY_OPERATORS = "забагато операторів підряд";
       
         static private bool IsSeparate(char s)
         {
             if ((" =".IndexOf(s) != -1))
             {
                return true;
             }

             return false;
         }

         static private bool IsOneSymbolOperator(char s)
         {
             if (("+-/*^()".IndexOf(s) != -1))
             {
                 return true;
             }

             return false;
         }

         static private bool IsThreeSymbolOperator( string input, int k)
         {
            
             if ("mdi".IndexOf(input[k]) != -1)
             {
                 string box = input[k].ToString() + input[k + 1] + input[k + 2];
                 if (("mod".IndexOf(box) != -1) || ("div".IndexOf(box) != -1) || ("inc".IndexOf(box) != -1) ||
                     ("dec".IndexOf(box) != -1))
                 {
                     return true;
                 }
             }

             return false;
         }
         
         static private bool IsCellName(string input, int i)
         {
             if (input[i].Equals('C') && char.IsDigit(input[i + 1]) && input[i + 2].Equals('R') && char.IsDigit(input[i + 3]))
             {
                 return true;
             }

             return false;
         }

         static private char GetShortOpSignature(char c1, char c2)
         {
             if (c1.Equals('d'))
             {
                 if (c2.Equals('e'))
                 {
                     return 'e';
                 }
                 else if(c2.Equals('i'))
                 {
                     return 'i';
                 }
             }

             return c1;
         }

        public static int ToInt( char c)
         {
             return (int)(c - '0');
         }

        public static double ToDouble(string c)
        {
            return Convert.ToDouble(c);
        }

        static private byte GetPriority(char s)
         {
             switch (s)
             {
                 case '(': return 0;
                 case ')': return 1;
                 case '+': return 4; 
                 case 'd': return 3; //dec
                 case 'i': return 2; //inc
                 case '-': return 5;
                 case '*': return 6;
                 case '/': return 6;
                 case 'm': return 7; //mod
                 case 'e': return 7; //div
                 case '^': return 8;
                 default: return 9;
             }
         }

          public static double Calculate(string input, DataGridView table)
         {
             string output = GetExpression(input, table);
             double result = Counting(output);
             return result;
        }

        static private string GetExpression(string input, DataGridView Table)
        {
             string output = string.Empty;
             Stack<char> opStack = new Stack<char>();

             for (int i = 0; i < input.Length; i++)
             {
                 if (IsSeparate(input[i]))
                 {
                     continue;
                 }

                 if (Char.IsDigit(input[i]))
                 {
                     while (!IsSeparate(input[i]) && !IsOneSymbolOperator(input[i]) &&
                            !IsThreeSymbolOperator(input, i))
                     {
                        output += input[i];
                        i++;
                        if (i == input.Length)
                        {
                            break;
                        }
                     }

                     output += " ";
                     i--;
                 }

                 if (IsOneSymbolOperator(input[i]) || IsThreeSymbolOperator(input, i))
                 {
                     if (input[i] == '(')
                     {
                         opStack.Push(input[i]);
                     }
                     else if (input[i] == ')')
                     {
                         char s = opStack.Pop();
                         while (s != '(')
                         {
                             output += s.ToString() + ' ';
                             s = opStack.Pop();
                         }
                     }
                    /* else if (input[i].Equals('-'))
                     {
                         if (UnaryMinus(input, i) || char.IsDigit(input[i+1]))
                         {
                             output += "-";
                             while ((i < (input.Length - 1))  && char.IsDigit(input[i+1]))
                             {
                                 output += input[i + 1];
                                 i++;
                             }

                             output += " ";
                         }
                     }*/
                     else
                     {
                             if (opStack.Count > 0 && GetPriority(GetShortOpSignature(input[i], input[i + 1])) <
                             GetPriority(opStack.Peek()))
                             {
                                 output += opStack.Pop().ToString() + " ";
                                 opStack.Push(GetShortOpSignature(input[i], input[i + 1]));
                             }
                             else
                             {
                                 opStack.Push(GetShortOpSignature(input[i], input[i + 1]));
                             }
                     }

                     if (IsThreeSymbolOperator(input, i))
                     {
                         i = i + 2;
                     }
                 }
                 
                if (IsCellName(input, i))
                {
                    int column = ToInt(input[i + 1]);
                    int row = ToInt(input[i + 3]);


                     output += ToDouble(Table[column-1, row-1].Value.ToString());
                     output += " ";
                     i = i + 3;
                 }
             }

             while (opStack.Count > 0)
             {
                 output += opStack.Pop() + " ";
             }

             return output;
        }

        static private bool UnaryMinus(string input, int i)
        {
            int k = i - 3;
            if (input[i-1].Equals('0') || input[i-1].Equals('(') || IsOneSymbolOperator(input[i-1])) 
            {
                return true;
            }
            else if(k > 0 && IsThreeSymbolOperator(input, k))
            {
                return true;
            }

            return false;
        }

        static private double Counting(string input)
        {
            Stack<double> temp = new Stack<double>();
            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!IsSeparate(input[i]) && !IsOneSymbolOperator(input[i]) && !char.IsLetter(input[i]))
                    {
                        a += input[i];
                        i++;
                        if (i == input.Length)
                        {
                            break;
                        }
                    }
                    if(!(a == ""))
                    {
                        temp.Push(Convert.ToDouble(a));
                    }
                    else
                    {
                        temp.Push(0.0);
                    }
                    i--;
                }
                else if (IsOneSymbolOperator(input[i]) || (char.IsLetter(input[i]) && !input[i].Equals('C') && !input[i].Equals('R')))
                {
                    if (!input[i].Equals('d') &&
                        !input[i].Equals('i'))
                    {
                        double a = temp.Pop();
                        double b = temp.Pop();

                        switch (input[i])
                        {
                            case '+':
                                result = b + a;
                                break;
                            case '-':
                                result = b - a;
                                break;
                            case '*':
                                result = b * a;
                                break;
                            case '/':
                                result = b / a;
                                break;
                            case '^':
                                result = Math.Pow(b, a);
                                break;
                            case 'm':
                                result = b % a;
                                break;
                            case 'i':
                                int k;
                                k = (int)(b / a);
                                result = (double) (k);
                                break;
                        }
                    }
                    else
                    {
                        if (input[i].Equals('d'))
                        {
                            double a = temp.Pop();
                            result = a++;
                        }
                        else if(input[i].Equals('i'))
                        {
                            double a = temp.Pop();
                            result = a--;
                        }
                        else
                        {
                            double a = temp.Pop();
                            result = a;
                        }
                    }

                    temp.Push(result);
                }
            }
            return temp.Peek();
        }
     }
}
