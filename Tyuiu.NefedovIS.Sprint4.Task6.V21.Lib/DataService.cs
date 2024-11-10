using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NefedovIS.Sprint4.Task6.V21.Lib
{
    public class DataService : ISprint4Task6V21
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(s => s.Length < 8);
            return count;
        }
    }
}
