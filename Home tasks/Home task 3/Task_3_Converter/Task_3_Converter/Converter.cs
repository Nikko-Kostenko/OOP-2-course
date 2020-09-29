using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Task_3_Converter
{
    class Converter
    {
        private double UAH_to_USD;
        private double UAH_to_EUR;

        public Converter(double USD, double EUR)
        {
            UAH_to_EUR = EUR;
            UAH_to_USD = USD;
        }

        public double ConvertUSD(double UAH)
        {
            double USD;

            try
            {
                if (UAH_to_USD == 0.0)
                {
                    throw new Exception("деление на 0");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            finally
            {
                USD = UAH / UAH_to_USD;
            }

            return USD;
        }

        public double ConvertEUR(double UAH)
        {
            double EUR;

            try
            {
                if (UAH_to_EUR == 0)
                {
                    throw new Exception("деление на 0");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            finally
            {
                EUR = UAH / UAH_to_EUR;
            }

            return EUR;
        }
    }
}
