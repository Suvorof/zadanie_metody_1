using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Add_Sub_Mul_Div
{
    class Program
    {
        static float Add(float a, float b, float sum)
        {
            sum = a + b;
            return sum;
        }

        static float Sub(float a, float b, float raznost)
        {
            raznost = a - b;
            return raznost;
        }

        static float Mul(float a, float b, float proizvedenie)
        {
            proizvedenie = a * b;
            return proizvedenie;
        }

        static float Div(float a, float b, float chastnoe)
        {
            chastnoe = a / b;
            return chastnoe;
        }

        static void Main()
        {
            Console.WriteLine("Введите первое число");
            string x = Console.ReadLine();
            float first_number = Convert.ToSingle(x);

            Console.WriteLine("Введите любой из предложенных математических операторов +, -, *, /: ");
            string sign = Console.ReadLine();

            Console.WriteLine("Введите второе число");
            string y = Console.ReadLine();
            float second_number = Convert.ToSingle(y);

            switch (sign)
            {
                case "+":

                    float sum = first_number + second_number;

                    Add(first_number, second_number, sum);
                    Console.WriteLine("{0} + {1} = {2}", first_number, second_number, sum);
                    Console.ReadKey();
                    break;

                case "-":

                    float raznost = first_number - second_number;

                    Sub(first_number, second_number, raznost);
                    Console.WriteLine("{0} - {1} = {2}", first_number, second_number, raznost);
                    Console.ReadKey();
                    break;

                case "*":

                    float proizvedenie = first_number * second_number;

                    Mul(first_number, second_number, proizvedenie);
                    Console.WriteLine("{0} * {1} = {2}", first_number, second_number, proizvedenie);
                    Console.ReadKey();
                    break;

                case "/":

                    if (second_number == 0)
                    {
                        Console.WriteLine("Деление на 0 невозможно");
                        Console.ReadKey();
                    }
                    else
                    {
                        float chastnoe = first_number / second_number;

                        Div(first_number, second_number, chastnoe);
                        Console.WriteLine("{0} / {1} = {2}", first_number, second_number, chastnoe);
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}
