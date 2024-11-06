using Tyuiu.NefedovIS.Sprint4.Task0.V21.Lib;
namespace Tyuiu.NefedovIS.Sprint4.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] a = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine("a = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 }\n");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumEvenArrEl(a));
        }
    }
}
