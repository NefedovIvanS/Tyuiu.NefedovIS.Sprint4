using Tyuiu.NefedovIS.Sprint4.Task6.V21.Lib;
namespace Tyuiu.NefedovIS.Sprint4.Task6.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string[] a = ["Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit"];

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a));
        }
    }
}
