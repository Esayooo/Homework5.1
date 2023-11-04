using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Вызов метода, который генерирует исключение.
                GenerateException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Произошла пользовательская ошибка: " + ex.Message);
            }
        }

        static void GenerateException()
        {
            // Генерация пользовательского исключения и его "поднятие" в вызывающий метод.
            throw new CustomException("Это пользовательское исключение.");
        }
    }

    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
   
