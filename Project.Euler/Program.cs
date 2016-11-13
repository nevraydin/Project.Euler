using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Question ID?");
                    // ReSharper disable once AssignNullToNotNullAttribute
                    var id = int.Parse(Console.ReadLine());
                    var sw = new Stopwatch();
                    sw.Start();
                    Console.WriteLine(Solutions.GetResult<object>(id) + "\nTotal ms: " + sw.ElapsedMilliseconds);
                    sw.Stop();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
