using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFresco
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colorsGoats = new List<string>();
            

            StreamReader sr = new StreamReader("goats.txt");
            string temp = sr.ReadLine();
            Console.WriteLine(temp);

            while (temp != "GOATS")
            {
                if (temp != "COLOURS") colorsGoats.Add(temp);
                temp = sr.ReadLine();
            }

            int[] countColorGoats = new int[colorsGoats.Count];

            while (!sr.EndOfStream)
            {
                temp = sr.ReadLine();
                int ind = FindIndexColor(colorsGoats, temp);
                countColorGoats[ind]++;
            }
            sr.Close();
            PrintMassive(countColorGoats);

        }

        static int FindIndexColor(List<string> colorsGoats, string temp)
        {
            for (int i = 0; i < colorsGoats.Count; i++)
                if (colorsGoats[i] == temp) return i;
            return - 1;
        }

        static void PrintMassive(int[] a)
        {
            foreach (var aa in a)
                Console.Write(aa + " ");
            Console.WriteLine();
        }
    }
}
