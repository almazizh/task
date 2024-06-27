using System;
using System.IO;


namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {

                string fileContent;

                string filePath = args[0];
                try
                {

                    fileContent = File.ReadAllText(filePath);
                    string[] str = fileContent.Split('\n');
                    int[] numbers = new int[str.Length];

                    for (int i = 0; i < str.Length; i++)
                    {
                        int.TryParse(str[i], out numbers[i]);
                    }

                    Array.Sort(numbers);
                    int m = numbers[numbers.Length / 2];
                   
                    int q = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        q += Math.Abs(numbers[i] - m);
                    }
                    Console.WriteLine(q);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Указанный файл не найден.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Произошла ошибка при чтении файла.");
                }
             }
            else
            {
                Console.WriteLine("Произошла ошибка. Неверный формат ввода.  Файл ");

            }



         

        }

      
        
    }
}
