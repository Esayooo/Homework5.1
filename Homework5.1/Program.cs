using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Попытка выполнить запрос к несуществующему веб-ресурсу.
                // Здесь может возникнуть исключение, например, System.Net.WebException.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Завершение программы.");
            }
        }
    }
}
