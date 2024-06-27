using System;


namespace Task1
{
    internal class Program
    {
        static int n;
        static int k;
        static int m;
        static void Main(string[] args)
        { 

           
            if (args.Length >= 2)
            {
               
                if (CheckNumber(args[0].ToString()) && CheckNumber(args[1].ToString()))
                {
                    n = Convert.ToInt32(args[0]);
                    m = Convert.ToInt32(args[1]);
                    string s = "1";
                    k = 1;
                    while (true)
                    {

                        if (m < 3)
                        {
                            ResultNumberM2();
                        }
                        else
                        {
                            ResultNumberM();
                        }
                        if (k == 1) { break; }
                        else
                        {                  
                            s += k;
                        }
                    }
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
                
                
            }else
                {
                    Console.WriteLine("Произошла ошибка. Неверный формат ввода. Введите 2 числовых аргумента");
                    Console.ReadKey();
                }
                
                                     
         
           

            
        }
        static void ResultNumberM() {
            for (int i = 1; i<m; i++)
            {
                k += 1;
                if (k > n)
                {
                    k = 1;
                }
            }
           
         }
        static void ResultNumberM2()
        {
            for (int i = 1; i <=m; i++)
            {
                k += 1;
                if (k > n)
                {
                    k = 1;
                }
            }

        }

        static bool CheckNumber (string s)
        {
            if (!int.TryParse(s, out int number))
            {
                Console.WriteLine("Неверный формат ввода. Введите 2 числовых аргумента");
                Console.ReadKey(); 
                return false;
            }

            return true; }
    }
}
