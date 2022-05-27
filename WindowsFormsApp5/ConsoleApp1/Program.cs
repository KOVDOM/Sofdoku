using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }

    
    class Program
    {
        static List<Feladvany> feladvanyok = new List<Feladvany>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("feladvanyok.txt");
            while (!sr.EndOfStream)
            {
                Feladvany f = new Feladvany(sr.ReadLine());
                feladvanyok.Add(f);
            }

            Console.WriteLine("Melyik méretett keresed? ");
            int db = 0;
            int keresettszam = Convert.ToInt32(Console.ReadLine());
            List<Feladvany> egymeretu = new List<Feladvany>();
            foreach (var item in feladvanyok)
            {
                if (item.Meret==keresettszam)
                {
                    db++;
                    egymeretu.Add(item);
                }
            }
            Console.WriteLine(db);
            Console.WriteLine();
            Random r = new Random();
            int index = r.Next(0, egymeretu.Count);
            egymeretu[index].Kirajzol();
            Console.WriteLine();

            int osszes = egymeretu[index].Meret* egymeretu[index].Meret;
            int kitoltve = 0;
            foreach (var item in egymeretu[index].Kezdo)
            {
                if (item!='0')
                {
                    kitoltve++;
                }
            }
            double szazalek = ((double)kitoltve / osszes) * 100;
            Console.WriteLine((int)szazalek+"%");
            string fajlnev = "sodoku";
            fajlnev += keresettszam.ToString();
            fajlnev += ".txt";
            StreamWriter sw = new StreamWriter(fajlnev);
            foreach (var item in egymeretu)
            {
                sw.WriteLine(item.Kezdo);
            }
            sw.Close();
            Console.ReadKey();
        }
    }
}
