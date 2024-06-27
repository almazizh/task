using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                try
                {

                 var tests = JsonConvert.DeserializeObject<Root>(File.ReadAllText(args[0]));

                var values = JsonConvert.DeserializeObject<Root>(File.ReadAllText(args[1]));


                FillTestValues(tests.Tests, values.Values);
                string reportJson = JsonConvert.SerializeObject(tests, Formatting.Indented, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
                File.WriteAllText("report.json", reportJson);
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
                Console.WriteLine("Неверный ввод. Введите файлы   tests.json values.json ");
            }
            }

        private static void FillTestValues(List<ValueJson> tests, List<ValueJson> values)
        {
            foreach (var test in tests)
            {
                foreach (var value in values)
                {
                    if (test.id == value.id)
                    {
                        test.value = value.value;
                        break;
                    }
                }

                if (test.values != null)
                {
                    FillTestValues(test.values, values);
                }
            }
        }
        public class Root
        {
          
            public List<ValueJson> Tests { get; set; }

          
            public List<ValueJson> Values { get; set; }
        }

        public class ValueJson
        {
           
            public int id { get; set; }

            
            public string title { get; set; }

           
            public string value { get; set; }


          
            public List<ValueJson> values { get; set; }

           
        }
    }
}