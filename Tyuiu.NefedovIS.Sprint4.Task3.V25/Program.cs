using Tyuiu.NefedovIS.Sprint4.Task3.V25.Lib;

namespace Tyuiu.NefedovIS.Sprint4.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] a = { { 7, 3, 5, 3, 6},
                { 4, 6, 2, 5, 7 },
                { 2, 3, 3, 3, 5 },
                { 2, 7, 7, 6, 2 },
                { 6, 6, 4, 3, 6 } };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a));
        }
    }
}
