using System;
using System.Threading;

namespace exercises
{
    internal class Program
    {
        enum level
        {
            Low,
            Medium,
            Hight
        }
        struct Grandfather
        {
            public string name;
            public level grouchinesslevel;
            public string[] grumblingphrases;
            public int bruises;
            public void Countsbruises(params string[] cursewords)
            {
                foreach (string elem in cursewords)
                {
                    foreach (string element in grumblingphrases)
                    {
                        if (elem == element)
                        {
                            bruises++;
                        }
                    }
                }
            }
        }
        static int Sum(params int[] paraments)
        {
            int sum = 0;
            for (int i = 0; i < paraments.Length; i++)
            {
                sum += paraments[i];
            }
            return sum;
        }
        static void Comp(int[] paraments, ref int comp)
        {
            comp = 1;
            for (int i = 0; i < paraments.Length; i++)
            {
                comp *= paraments[i];
            }
        }
        static void Average(int[] paraments, out double average)
        {
            double sum = 0;
            for (int i = 0; i < paraments.Length; i++)
            {
                sum += paraments[i];
            }
            average = sum / paraments.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1\nПоменять 2 числа из массива местами");
            Random rnd = new Random();
            int[] array = new int[20];
            for (int i = 0; i <= 19; i++)
            {
                array[i] = rnd.Next(99999);
            }
            for (int i = 0; i <= 19; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nВведите 1 число:");
            int number1, number2, number3, number4;

            int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введите 2 число:");
            int.TryParse(Console.ReadLine(), out number2);
            for (int i = 0; i <= 19; i++)
            {
                number3 = number1;
                number4 = number2;
                if (array[i] == number3)
                {
                    array[i] = number2;
                }
                else if (array[i] == number4)
                {
                    array[i] = number1;
                }
            }
            for (int i = 0; i <= 19; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n\nУпражнение 2\nВывести среднее арифметическое, сумму и произведение массива");
            Random rnd1 = new Random();
            int[] array1 = new int[5];
            int sum = 0;
            int comp = 1;
            double average;
            for (int i = 0; i <= 4; i++)
            {
                array1[i] = rnd.Next(99);
                Console.Write(array1[i] + " ");
            }
            sum = Sum(array1);
            Console.WriteLine($"\nCумма равна = {sum}");
            Comp(array1, ref comp);
            Console.WriteLine($"Произведение равно = {comp}");
            Average(array1, out average);
            Console.WriteLine($"Среднее арифметическое равно = {average}\n");

            Console.WriteLine("Упражнение 3\nВведите число от 0 до 9, чтобы получить рисунок или exit/закрыть для завершения работы программы:");
            string some = Console.ReadLine();
            if (some == "exit" || some == "закрыть")
            {
                System.Environment.Exit(0);
            }
            try
            {
                int num = Convert.ToInt32(some);
                switch (num)
                {
                    case 0:
                        Console.WriteLine("###\n# # \n###");
                        break;
                    case 1:
                        Console.WriteLine(" # \n # \n #\n # ");
                        break;
                    case 2:
                        Console.WriteLine("###\n  #\n #  \n###");
                        break;
                    case 3:
                        Console.WriteLine("###\n  #\n###\n  #\n###");
                        break;
                    case 4:
                        Console.WriteLine("# #\n# #\n  #");
                        break;
                    case 5:
                        Console.WriteLine("###\n#  \n###\n  #\n###");
                        break;
                    case 6:
                        Console.WriteLine("###\n#  \n###\n# #\n###");
                        break;
                    case 7:
                        Console.WriteLine("###\n  #\n #\n#  \n#  ");
                        break;
                    case 8:
                        Console.WriteLine("###\n# #\n###\n# #\n###");
                        break;
                    case 9:
                        Console.WriteLine("###\n# #\n###\n  #\n###");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Число должно быть от 0 до 9 \n");
                        Thread.Sleep(5000);
                        Console.ResetColor();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Вы должны ввести число");
            }

            Console.WriteLine("\nУпражнение 4\nСоздать структуру Дед и вернуть количество фингалов");
            string[] cursewords = {"Проститутки", "Гады"};
            string[] васяwords = {"Проститутки", "Дебилы"};
            string[] коляwords = {"Гады", "Уроды", "Дурак"};
            string[] ваняwords = {"Мразь"};
            string[] витяwords = {"Огрызок", "Рахитоид ", "Огузок", "Инвалид"};
            string[] сашаwords = {"Проститутки", "Гады", "Дебилы", "Твари", "Уебки", "Ебланы"};
            Grandfather Вася = new Grandfather();
            Вася.name = "Вася";
            level ВасяgrouchinessLevel = level.Low;
            Вася.grouchinesslevel = ВасяgrouchinessLevel;
            Вася.grumblingphrases = васяwords;
            Вася.bruises = 0;
            Вася.Countsbruises(cursewords);
            Grandfather Коля = new Grandfather();
            Коля.name = "Коля";
            level КоляgrouchinessLevel = level.Medium;
            Коля.grouchinesslevel = КоляgrouchinessLevel;
            Коля.grumblingphrases = коляwords;
            Коля.bruises = 0;
            Коля.Countsbruises(cursewords);
            Grandfather Ваня = new Grandfather();
            Ваня.name = "Ваня";
            level ВаняgrouchinessLevel = level.Medium;
            Ваня.grouchinesslevel = ВаняgrouchinessLevel;
            Ваня.grumblingphrases = ваняwords;
            Ваня.bruises = 0;
            Ваня.Countsbruises(cursewords);
            Grandfather Витя = new Grandfather();
            Витя.name = "Витя";
            level ВитяgrouchinessLevel = level.Hight;
            Витя.grouchinesslevel = ВитяgrouchinessLevel;
            Витя.grumblingphrases = витяwords;
            Витя.bruises = 0;
            Витя.Countsbruises(cursewords);
            Grandfather Саша = new Grandfather();
            Саша.name = "Саша";
            level СашаgrouchinessLevel = level.Hight;
            Саша.grouchinesslevel = СашаgrouchinessLevel;
            Саша.grumblingphrases = сашаwords;
            Саша.bruises = 0;
            Саша.Countsbruises(cursewords);
            Console.WriteLine($"Количество синяков у Васи: {Вася.bruises}\n" +
                              $"Количество синяков у Коли: {Коля.bruises}\n" +
                              $"Количество синяков у Вани: {Ваня.bruises}\n" +
                              $"Количество синяков у Вити: {Витя.bruises}\n" +
                              $"Количество синяков у Саши: {Саша.bruises}");
            Console.ReadKey();
        }
    }
}
