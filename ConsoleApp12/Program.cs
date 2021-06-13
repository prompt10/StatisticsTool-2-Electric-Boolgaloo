using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fate, Mode;
            double number, n = 2;
            List<double> add_list = new List<double>();
            //for (int i = n; i < n; i++)
            while (n == 2)
            {
                Fate = Console.ReadLine();
                bool success = double.TryParse(Fate, out number);
                if (success)
                {
                    add_list.Add(number);
                    //n++;
                }
                if (Fate == "End")
                {
                    break;
                }

            }
                
            double[] terms = add_list.ToArray();

            while (n == 2)
            {
                Mode = Console.ReadLine();
                if (Mode == "FindMax")
                {
                    double max = Int32.MinValue;
                    for (var i = 0; i < terms.Length; i++)
                    {
                        if (terms[i] > max)
                        {
                            max = terms[i];
                        }
                    }
                    Console.WriteLine(max);
                }

                if (Mode == "FindMin")
                {
                    double min = terms.Min();
                    Console.WriteLine(min);
                }

                if (Mode == "FindMean")
                {
                    double avg = Queryable.Average(terms.AsQueryable());
                    Console.WriteLine(avg);
                }
                if (Mode == "End")
                {
                    break;
                }
                if (Mode != "FindMean" && Mode != "FindMin" && Mode != "FindMax")
                {
                    Console.WriteLine("Invalid Mode");
                }
                
            }
        }
    }
}
