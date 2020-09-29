using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasMetodosOrdenamiento
{
    class Metodos
    {
        static Random r = new Random();

        public static void RandomFill(int[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = r.Next(100);
            }
        }

        public static void Colorear(string args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(args);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void printVector(int[] vs)
        {
            for (int i = 0; i < vs.GetLength(0); i++)
            {
                Console.Write((i == 0) ? "{" + (vs[i]) + ", " : (i < vs.GetLength(0) - 1) ? vs[i] + ", " : vs[i] + "}\n");
            }
        }

        static void printVectorColor(int[] vs, int index1, int index2)
        {
            for (int i = 0; i < vs.GetLength(0); i++)
            {
                if (i == 0) Console.Write("{");
                if (i == index1 || i == index2) Colorear(vs[i].ToString()); else Console.Write(vs[i].ToString());
                if (i < vs.GetLength(0) - 1) Console.Write(", "); else Console.WriteLine("}");
            }
        }

        public static void Burbuja(int[] vs)
        {
            int cont = 0;
            for (int i = 0; i < vs.Length -1; i++)
            {
                for (int j = 0; j < vs.Length; j++)
                {
                    cont += 1;
                    if (vs[i] < vs[j])
                    {
                        int temp = vs[i];
                        vs[i] = vs[j];
                        vs[j] = temp;

                        //printVectorColor(vs, i, j);
                    }
                    else
                    {
                        //printVector(vs);
                    }
                }
            }
            Console.WriteLine("\titeraciones: " + cont);
        }
        public void InsercionDirecta(int[] vs)
        {
            int auxili;
            int j;
            for (int i = 0; i < vs.Length; i++)
            {   
                auxili = vs[i];
                j = i - 1;
                while (j >= 0 && vs[j] > auxili)
                {
                    vs[j + 1] = vs[j];
                    j--;
                }
                vs[j + 1] = auxili;
            }
        }


        public void InsercionBinaria(int[] vs)
        {
            int auxiliar, q, izqui, dere, j=0;
            for (int i = 0; i < vs.Length; i++)
            {
                auxiliar = vs[i];
                izqui = 0;
                dere = i - 1;
                while (izqui <= dere)
                {
                    q = ((izqui + dere) / 2);
                    if (auxiliar < vs[q])
                    {
                        dere = q - 1;
                    }
                    else
                    {
                        izqui = q + 1;
                    }
                    j = i - 1;
                    while (j >= izqui)
                    {
                        vs[j + 1] = vs[j];
                        j = j - 1;
                    }
                    vs[izqui] = auxiliar;
                }
            }
        }



    }
}
