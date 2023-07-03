using System.Linq;

namespace List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объявление листа
            var intList = new List<int>();
            Console.WriteLine("Введите значения листа");
            for (int i = 0; i < 3; i++)
            {

                intList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("");
            // сортировка листа
            intList.Sort();
            Console.WriteLine("Вывод отсортированного листа");
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Вывод чисел которые делятся на 2 без остатка");
            var R = intList.Where(j => j % 2 == 0);
            foreach (int i in R)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Console.WriteLine("Вывод чисел которые больше 42");
            var c42 = intList.Where(j => j > 42);
            foreach (int i in c42)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Console.WriteLine("Вывод суммы чисел");
            Console.WriteLine(intList.Sum());


            var stringList = new List<string>() { "fdsafsdfa", "5456468dsAAAA", "FFFFF" };
            Console.WriteLine("Вывод строк которые не содержат пробелов");
            var S = stringList.Where(p => !p.Contains(" "));
            foreach (var i in S)
            {
                Console.WriteLine(i);
            }
            Console.Write("Введите искомую подстроку ");
            var SS = stringList.Where(p => p.Contains(Console.ReadLine()));
            foreach (var i in SS)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Вывод строк содержащие заглавные буквы");
            foreach (string str in stringList)
            {
                if (str.Any(char.IsUpper))
                {

                    Console.WriteLine(str);
                }
            }
            Console.WriteLine("Вывод true/false если есть или нет числа в листе");
            bool test = true;
            foreach (string str in stringList)
            {
                if (str.Any(char.IsDigit))
                {

                    Console.WriteLine(test);
                    break;

                }
                else
                {
                    test = false;
                    Console.WriteLine(test);
                    break;
                }
            }
        }
    }
}