using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                // Попытка обратиться к элементу, выходящему за пределы массива.
                int value = arr[5];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Завершение обработки массива.");
            }
        }
    }
}
