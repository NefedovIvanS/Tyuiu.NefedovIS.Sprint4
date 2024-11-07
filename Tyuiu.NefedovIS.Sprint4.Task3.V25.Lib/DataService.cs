using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NefedovIS.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length / 5; i++)
            {
                p *= array[3, i];
            }
            return p;
        }
    }
}
