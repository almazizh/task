using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {

                string fileCenterContent;
                string filePointContent;
                string fileOnePath = args[0];
                string fileTwoPath = args[1];
                try
                {
                    fileCenterContent = File.ReadAllText(fileOnePath);
                    string[] StringCenter = fileCenterContent.Split('\n');
                    filePointContent = File.ReadAllText(fileTwoPath);
                    string[] StringPoint = filePointContent.Split('\n');
                   
                    for (int i = 0; i < StringPoint.Length; i++)
                    {
                        
                        if (StringCenter.Length == 2)
                        {
                          
                            if (StringCenter[0].Split().Length >1)
                            {
                                if (CheckFloat(StringCenter[0].Split()[0])&& CheckFloat(StringCenter[0].Split()[1])&& CheckFloat(StringCenter[1].Split()[0])&& CheckFloat(StringPoint[i].Split()[0])&& CheckFloat(StringPoint[i].Split()[1])){
                                   
                                    Result(Convert.ToDouble(StringCenter[0].Split()[0]), Convert.ToDouble(StringCenter[0].Split()[1]), Convert.ToDouble(StringCenter[1].Split()[0]), Convert.ToDouble(StringPoint[i].Split()[0]), Convert.ToDouble(StringPoint[i].Split()[1]));
                                }
                                else
                                {
                                    Console.WriteLine("Значения в фалах не соответствуют условию");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Введенные значения центра и радуса не соответствуют условию");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введенные значения центра и радуса не соответствуют условию");
                        }

                    }

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
                Console.WriteLine("Произошла ошибка. Неверный формат ввода. Введите путь к 2 файлам ");

            }
        
        }
        static bool CheckFloat(string input)
        {
            
           

            float floatValue;
            bool isFloat = float.TryParse(input, out floatValue);

            if (isFloat)
            {
                // Введенное значение является числом с плавающей запятой (float)
               return true;
            }
            else
            {
                // Введенное значение является строкой
                return false;
            }
        }

        static void Result(double centerX, double centerY, double radius, double pointX, double pointY)
        {
            
                      

            double distance = Math.Sqrt(Math.Pow(pointX - centerX, 2) + Math.Pow(pointY - centerY, 2));

            if (distance == radius)
            {
                Console.WriteLine("0");
            }
            else if (distance < radius)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }

           
        }
    }
}
