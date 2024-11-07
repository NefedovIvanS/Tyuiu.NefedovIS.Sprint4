using Tyuiu.NefedovIS.Sprint4.Task2.V3.Lib;
namespace Tyuiu.NefedovIS.Sprint4.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************\n");

            Console.Write("Введите кол-во элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[len];

            for (int i = 0; i < len; i++)
            {
                a[i] = rnd.Next(2,8);
            }

            Console.Write("Массив: { ");
            for (int i = 0; i < len - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.WriteLine(a[len - 1] + " }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a));
        }
    }
}
