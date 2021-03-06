﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Threading;
using System.Windows.Forms;

/* 
This is a mixed parser which uses reverse polish notation to calculate expressions 
*/
namespace LabCalc1
{

    class Rpn
    {    
         private static bool IsSeparate(char s)
         {
             if ((" =".IndexOf(s) != -1))
             {
                return true;
             }

             return false;
         }

         private static bool IsOneSymbolOperator(char s)
         {
             if (("+-/*^()".IndexOf(s) != -1))
             {
                 return true;
             }

             return false;
         }

         private static bool IsThreeSymbolOperator( string input, int k)
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
         
         public static bool IsCellName(string input, int i)
         {
             if (input[i].Equals('C') && char.IsDigit(input[i + 1]) && input[i + 2].Equals('R') && char.IsDigit(input[i + 3]))
             {
                 return true;
             }

             return false;
         }

         private static bool IsUnaryMinus(string input, int i)
         {
             if (input[i].Equals('-'))
             {
                 int k = i - 3;
                 if (i.Equals(0) || input[i - 1].Equals('(') || IsOneSymbolOperator(input[i - 1]))
                 {
                     return true;
                 }
                 else if (k > 0 && IsThreeSymbolOperator(input, k))
                 {
                     return true;
                 }
             }

             return false;
         }

         private static double GetCellValue(string input, int i, DataGridView table)
         {
            int column = ToInt(input[i + 1]);
            int row = ToInt(input[i + 3]);
            if (table[column - 1, row - 1].Value != null)
            {
                return ToDouble(table[column - 1, row - 1].Value.ToString());
            }
            else
            {
                return 0;
            }
         }

         private static double GetNameCellValue(string input, DataGridView table)
         {
             int column = ToInt(input[ 1]);
             int row = ToInt(input[3]);
             if (table[column - 1, row - 1].Value != null)
             {
                 return ToDouble(table[column - 1, row - 1].Value.ToString());
             }
             else
             {
                 return 0;
             }
         }

        private static char GetShortOpSignature(char c1, char c2)
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

         private static byte GetPriority(char s)
         {
             switch (s)
             {
                 case '(': return 0;
                 case ')': return 1;
                 case '+': return 4;
                 case 'd': return 3; //dec
                 case 'n': return 2; //inc
                 case '-': return 5;
                 case '*': return 6;
                 case '/': return 6;
                 case 'm': return 7; //mod
                 case 'i': return 7; //div
                 case '^': return 8;
                 default: return 9;
             }
         }

         public static int ToInt( char c)
         {
             return (int)(c - '0');
         }

         public static double ToDouble(string c)
        {
            return Convert.ToDouble(c);
        }

         //---Main---Functions---------------------------------------------------------------------


         //Calculates---Public---Function---To---Get---Cell---Value--------------------------------

         public static double Calculate(string input, DataGridView table, Cell cell)
         {
             List<string> names = new List<string>();
             string output = GetExpression(input,ref names, cell, table);

             if (!dataManager.CheckRecursion(cell))
             {
                 dataManager.updateCellReference(cell, table, names);
                 double result = Counting(output);
                 return result;
             }
             else
             {
                 cell.Exp = string.Empty;
                 cell.Value = 0;
                dataManager.deleteCellReferences(cell);
                MessageBox.Show("ошибка рекурсии");
             }
             
             return 0;
         }


         //Takes---String---&---Table---To---Get--Reverse-Polish-Anotation-------------------------
         private static string GetExpression(string input,ref List<string> names, Cell cell, DataGridView table)
         {
            
             string output = string.Empty;
             Stack<char> opStack = new Stack<char>();

             for (int i = 0; i < input.Length; i++) // analyzing every symbol
             {
                 if (IsSeparate(input[i]))// '=' is a saparate symbol
                 {
                     continue;
                 }

                 if (Char.IsDigit(input[i])) //'0-9' values symbols
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

                 if (IsOneSymbolOperator(input[i]) || IsThreeSymbolOperator(input, i))//operators
                 {
                     if (input[i] == '(')//for '(' symbol
                     {
                         opStack.Push(input[i]);
                     }
                     else if (input[i] == ')')//for ')' symbol. All symbols between '(' and ')' wil have higher priority
                     {
                         char s = opStack.Pop();
                         while (s != '(')
                         {
                             output += s.ToString() + ' ';
                             s = opStack.Pop();
                         }
                     }
                     else if (IsUnaryMinus(input, i))//For unary minus before numbers or cells names
                     {
                         i++;
                         if (!IsCellName(input, i)) //for numbers
                         { 
                             output += "0 ";
                             while (char.IsDigit(input[i]))
                             {
                                 output += input[i];
                                 i++;
                                 if (i == input.Length) break;
                             }
                             output += " -";
                         }
                         else
                         {
                            output += "0 ";
                            output += GetCellValue(input, i, table);
                            string name = input[i].ToString() + input[i + 1].ToString() + input[i + 2].ToString() +
                                          input[i + 3].ToString();
                            names.Add(name);
                            cell.DownCells.Add(dataManager.GetCell(name, table));
                            output += " -";
                        }
                     }
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

                     if (!(i >= input.Length) && IsThreeSymbolOperator(input, i))
                     {
                         i = i + 2;
                     }
                 }
                 
                 if (!(i >= input.Length) && IsCellName(input, i))
                 {
                     output += GetCellValue(input, i, table) + " ";
                     string name = input[i].ToString() + input[i + 1].ToString() + input[i + 2].ToString() +
                                   input[i + 3].ToString();
                     names.Add(name);
                    cell.DownCells.Add(dataManager.GetCell(name, table));

                    i = i + 3;
                 }
             }

             while (opStack.Count > 0)
             {
                 output += opStack.Pop() + " ";
             }

             return output;
         }


        //Takes---Genered---Reverse-Polish-Anotation---&---Calculates---Value----------------------

        private static double Counting(string input)
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
                                int m = (int) b;
                                int n = (int) a;
                                int difResult;
                                Math.DivRem(m, n, out difResult);
                                result = difResult;
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
