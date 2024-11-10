using Tyuiu.NefedovIS.Sprint4.Task7.V17.Lib;
namespace Tyuiu.NefedovIS.Sprint4.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************\n");

            Console.Write("Массив: \n");
            string str = "753159864";
            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.Write("\n");
            }
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество чётных элементов: {ds.Calculate(rows, columns, str)}");
        }
    }
}
