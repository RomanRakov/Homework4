using System;

namespace lab5
{
    class Program
    {
        static int max(int newnumber1, int newnumber2)
        {
            if (newnumber1 > newnumber2)
            {
                return newnumber1;
            }
            else
            {
                return newnumber2;
            }
        }
        static void swapper(ref string firstnumber, ref string secondnumber)
        {
            string thirdnumber;
            thirdnumber = firstnumber;
            firstnumber = secondnumber;
            secondnumber = thirdnumber;
        }
        static void factorial(int value)
        {
            int fact = 1;
            try
            {
                for (int i = 1; i <= value; i++)
                {
                    checked
                    {
                        fact = fact * i;
                    }
                }
                bool result = true;
                Console.WriteLine(result);

            }
            catch
            {
                bool result = false;
                Console.WriteLine(result);
            }
        }
        static int Factorial(int newvalue)
        {
            if (newvalue == 1)
            {
                newvalue = 1;
                return newvalue;
            }
            else
            {
                return newvalue * Factorial(newvalue - 1);
            }
        }
        static int NOD(int newvalue1, int newvalue2)
        {
            while (newvalue1 != newvalue2)
            {
                if (newvalue1 > newvalue2)
                {
                    newvalue1 = newvalue1 - newvalue2;
                }
                else
                {
                    newvalue2 = newvalue2 - newvalue1;
                }
            }
            return (newvalue1);

        }
        static int NOD(int newvalue1, int newvalue2, int newvalue3)
        {
            int temporarynod = NOD(newvalue1, newvalue2);
            int Nod = NOD(temporarynod, newvalue3);
            return Nod;
        }
        static int Fibonachi(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                return Fibonachi(number - 1) + Fibonachi(number - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1\nНаписать метод, возвращающий наибольшее из двух чисел\nВведите 1 число:");
            int newnumber1, newnumber2;
            string number1 = Console.ReadLine();
            int.TryParse(number1, out newnumber1);
            Console.WriteLine("Введите 2 число:");
            string number2 = Console.ReadLine();
            int.TryParse(number2, out newnumber2);
            int Max = max(newnumber1, newnumber2);
            Console.WriteLine($"Максимальное значение = {Max}\n");

            Console.WriteLine("Упражнение 5.2\nНаписать метод, который меняет местами значения двух передаваемых параметров\nВведите 1 число:");
            string firstnumber = Console.ReadLine();
            Console.WriteLine("Введите 2 число:");
            string secondnumber = Console.ReadLine();
            swapper(ref firstnumber, ref secondnumber);
            Console.WriteLine($"Новое значение первого числа = {firstnumber}\nНовое значение второго числа = {secondnumber}\n");

            Console.WriteLine("Упражнение 5.3\nНаписать метод вычисления факториала числа\nВведите число:");
            int value;
            int.TryParse(Console.ReadLine(), out value);
            factorial(value);

            Console.WriteLine("Упражнение 5.4\nНаписать рекурсивный метод вычисления факториала числа.\nВведите число:");
            int newvalue;
            int.TryParse(Console.ReadLine(), out newvalue);
            int fact = Factorial(newvalue);
            Console.WriteLine($"Факториал = {fact}\n");

            Console.WriteLine("Домашнее задание 5.1\nНаписать метод, который вычисляет НОД для 2 чисел\nВведите 1 число:");
            int newvalue1, newvalue2;
            string value1 = Console.ReadLine();
            int.TryParse(value1, out newvalue1);
            Console.WriteLine("Введите 2 число:");
            string value2 = Console.ReadLine();
            int.TryParse(value2, out newvalue2);
            int nod = NOD(newvalue1, newvalue2);
            Console.WriteLine($"НОД = {nod}\n");

            Console.WriteLine("Написать метод, который вычисляет НОД для 3 чисел\nВведите 1 число:");
            int firstvalue1, secondvalue2, thirdvalue3;
            string firstvalue = Console.ReadLine();
            int.TryParse(firstvalue, out firstvalue1);
            Console.WriteLine("Введите 2 число:");
            string secondvalue = Console.ReadLine();
            int.TryParse(secondvalue, out secondvalue2);
            Console.WriteLine("Введите 3 число:");
            string thirdvalue = Console.ReadLine();
            int.TryParse(thirdvalue, out thirdvalue3);
            int Nod = NOD(firstvalue1, secondvalue2, thirdvalue3);
            Console.WriteLine($"НОД = {Nod}\n");

            Console.WriteLine("Домашнее задание 5.2\nНаписать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи\nВведите число:");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            int fib = Fibonachi(number);
            Console.WriteLine($"Значение n-го числа = {fib}");
            Console.ReadKey();
        }
    }
}
