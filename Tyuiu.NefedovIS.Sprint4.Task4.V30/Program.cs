using Tyuiu.NefedovIS.Sprint4.Task4.V30.Lib;
namespace Tyuiu.NefedovIS.Sprint4.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] a =
            {
                { 3, 4, 6, 6, 5 },
                { 6, 7, 6, 3, 5 },
                { 5, 3, 5, 7, 6 },
                { 6, 4, 7, 6, 6 },
                { 7, 4, 3, 4, 5 }
            };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a));
        }
    }
}
