using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter write = new StreamWriter("2.txt");
            Regex reg = new Regex(@"(0[1-9]|1[12])\.(0[1-9]|[12][0-9]|3[01])\.([0-9]{4})");
            string text = File.ReadAllText("1.txt");
            MatchCollection all = reg.Matches(text);
            foreach (Match match in all)
            {
                if (match.Length > 0)
                {
                    write.WriteLine(match.ToString());
                }
            }
            write.Close();
        }
    }
}