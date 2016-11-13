using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Euler
{
    public static class Solutions
    {
        public static T GetResult<T>(int id)
        {
            switch (id)
            {
                case 21:
                    return (T)Convert.ChangeType(CalculateAmicableNumbers(), typeof(T));
                case 22:
                    return (T)Convert.ChangeType(CalculateNamesScore(), typeof(T));
                default:
                    return (T)Convert.ChangeType("No solution yet..", typeof(T));
            }
        }

        public static decimal CalculateNamesScore()
        {
            var nameList = File.ReadAllText(@"C:\p022_names.txt")
                .Split(',').Select(x => x.Trim('"')).OrderBy(x => x).ToList();

            var point = 0;
            var index = 0;
            var total = 0;
            foreach (var t in nameList)
            {
                for (var j = 0; j < t.Count(); j++)
                {
                    while (t[j] != ',')
                    {
                        point += t[j] - 64;
                        break;
                    }
                }

                total += point * index;

                point = 0;
                index++;
            }

            return total;
        }

        public static string CalculateAmicableNumbers(int total = 0, int index = 1)
        {
            var text = string.Empty;
            
            for (var i = 1; i < 10000; i++)
            {
                var temp1 = 0;
                var temp2 = 0;

                for (var j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        temp1 += j;
                }
                
                for (var k = 1; k < temp1; k++)
                {
                    if (temp1 % k == 0)
                        temp2 += k;
                }

                if (temp2 == i && i != temp1)
                {
                    total += i;
                    text += index + ": " + i + " , " + temp1 + "\n";
                    index++;
                }
            }
            text += "Total: " + total;
            return text;
        }
    }
}
