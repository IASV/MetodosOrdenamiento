using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PruebasMetodosOrdenamiento
{
    class Metodos
    {
        static Random r = new Random();

        public static void RandomFill(int[] vs)
        {
            for (int i = 0; i < vs.Length-1; i++)
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

        static void printvs(int[] vs)
        {
            for (int i = 0; i < vs.GetLength(0); i++)
            {
                Console.Write((i == 0) ? "{" + (vs[i]) + ", " : (i < vs.GetLength(0) - 1) ? vs[i] + ", " : vs[i] + "}\n");
            }
        }

        static void printvsColor(int[] vs, int index1, int index2)
        {
            for (int i = 0; i < vs.GetLength(0); i++)
            {
                if (i == 0) Console.Write("{");
                if (i == index1 || i == index2) Colorear(vs[i].ToString()); else Console.Write(vs[i].ToString());
                if (i < vs.GetLength(0) - 1) Console.Write(", "); else Console.WriteLine("}");
            }
        }

        public static int Burbuja(int[] vs)
        {
            int cont = 0;
            for (int i = 0; i < vs.Length - 1; i++)
            {
                for (int j = i; j < vs.Length; j++)
                {
                    cont++;
                    if (vs[i] < vs[j])
                    {
                        int temp = vs[i];
                        vs[i] = vs[j];
                        vs[j] = temp;

                        //printvsColor(vs, i, j);
                    }
                    else
                    {
                        //printvs(vs);
                    }
                }
            }

            return cont;
        }
        public static int InsercionDirecta(int[] vs)
        {
            int cont = 0;
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
                    cont += 1;
                }
                vs[j + 1] = auxili;
                
            }
            return cont;
        }


        public static int InsercionBinaria(int[] vs)
        {
            int auxiliar, q, izqui, dere, j, cont = 0;
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
                        cont++;
                    }
                    vs[izqui] = auxiliar;
                }
            }
            return cont;
        }

        public static int ShellSort(int[] vs)
        {
            int cont = 0;
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = vs.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (vs.Length - salto))
                    {
                        if (vs[e - 1] > vs[(e - 1) + salto])
                        {
                            auxi = vs[(e - 1) + salto];
                            vs[(e - 1) + salto] = vs[e - 1];
                            vs[(e - 1)] = auxi;
                            sw = 1;
                            cont++;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
            return cont;
        }

        public static int quicksort(int[] vs, int primero, int ultimo)
        {
            int cont = 0;
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vs[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vs[i] < pivote) i++;
                while (vs[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vs[i];
                    vs[i] = vs[j];
                    vs[j] = temp;
                    i++;
                    j--;
                }
                cont++;
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vs, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vs, i, ultimo);
            }
            return cont;
        }

        public static int ShakerSort(int[] vs)
        {
            int cont = 0;
            int n = vs.Length;
            int izq = 1;
            int k = n;
            int aux;
            int der = n-1;

            do
            {
                for (int i = der; i > izq; i--)
                {

                    if (vs[i - 1] >= vs[i])
                    {
                        aux = vs[i - 1];
                        vs[i - 1] = vs[i];
                        vs[i] = aux;
                        k = i;
                    }
                    cont++;
                }
                izq = k + 1;
                for (int i = izq; i <= der; i++)
                {
                    if (vs[i - 1] >= vs[i])
                    {
                        aux = vs[i - 1];
                        vs[i - 1] = vs[i];
                        vs[i] = aux;
                        k = 1;
                    }
                    cont++;
                }
                der = k - 1;
            }
            while (der >= izq);

            return cont;
        }


        public static int MergeSort(int[] x)
        {
            int cont = 0;
            MergeSort(x, 0, x.Length - 1);
            return cont;
        }

        static private void MergeSort(int[] x, int desde, int hasta)
        {
            //Condicion de parada
            if (desde == hasta)
                return;

            //Calculo la mitad del array
            int mitad = (desde + hasta) / 2;

            //Voy a ordenar recursivamente la primera mitad
            //y luego la segunda
            MergeSort(x, desde, mitad);
            MergeSort(x, mitad + 1, hasta);

            //Mezclo las dos mitades ordenadas
            int[] aux = Merge(x, desde, mitad, mitad + 1, hasta);
            Array.Copy(aux, 0, x, desde, aux.Length);
        }

        //Método que mezcla las dos mitades ordenadas
        static private int[] Merge(int[] x, int desde1, int hasta1, int desde2, int hasta2)
        {
            int a = desde1;
            int b = desde2;
            int[] result = new int[hasta1 - desde1 + hasta2 - desde2 + 2];

            for (int i = 0; i < result.Length; i++)
            {
                
                if (b != x.Length)
                {
                    if (a > hasta1 && b <= hasta2)
                    {
                        result[i] = x[b];
                        b++;
                    }
                    if (b > hasta2 && a <= hasta1)
                    {
                        result[i] = x[a];
                        a++;
                    }
                    if (a <= hasta1 && b <= hasta2)
                    {
                        if (x[b] <= x[a])
                        {
                            result[i] = x[b];
                            b++;
                        }
                        else
                        {
                            result[i] = x[a];
                            a++;
                        }
                    }
                }
                else
                {
                    if (a <= hasta1)
                    {
                        result[i] = x[a];
                        a++;
                    }
                }
            }
            return result;
        }
    }

}

