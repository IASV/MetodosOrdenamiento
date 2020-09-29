using System;
using System.IO;
using System.Net.WebSockets;

namespace PruebasMetodosOrdenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Datos.txt",true);
            int cont = 0;
            for (int j = 5; j < 6; j++)
            {
                switch (j)
                {
                    case 0:
                        Console.WriteLine("\n----------Metodo Burbuja----------\n" + "Data".PadRight(8) + "Time".PadRight(19) + "Iterations".PadRight(12));
                        sw.WriteLine("\n----------Metodo Burbuja----------\n");
                        break;
                    case 1:
                        Console.WriteLine("\n----------Metodo Inserción Directa----------\n" + "Data".PadRight(8) + "Time".PadRight(19) + "Iterations".PadRight(12));
                        sw.WriteLine("\n----------Metodo Inserción Directa----------\n");
                        break;
                    case 2:
                        Console.WriteLine("\n----------Metodo Inserción Binaria----------\n" + "Data".PadRight(8) + "Time".PadRight(19) + "Iterations".PadRight(12));
                        sw.WriteLine("\n----------Metodo Inserción Binaria----------\n");
                        break;
                    case 3:
                        Console.WriteLine("\n----------Metodo Shell Sort----------\n" + "Data".PadRight(8) + "Time".PadRight(19) + "Iterations".PadRight(12));
                        sw.WriteLine("\n----------Metodo Shell Sort----------\n");
                        break;
                    case 4:
                        Console.WriteLine("\n----------Metodo Quick Sort----------\n" + "Data".PadRight(8) + "Time".PadRight(19) + "Iterations".PadRight(12));
                        sw.WriteLine("\n----------Metodo Qick Sort----------\n");
                        break;
                    case 5:
                        Console.WriteLine("\n----------Metodo Shaker Sort----------\n" + "Data".PadRight(8) + "Time".PadRight(19) + "Iterations".PadRight(12));
                        sw.WriteLine("\n----------Metodo Shaker Sort----------\n");
                        break;
                    case 6:
                        Console.WriteLine("\n----------Metodo Merge Sort----------\n" + "Data".PadRight(8) + "Time".PadRight(19) + "Iterations".PadRight(12));
                        sw.WriteLine("\n----------Metodo Merge Sort----------\n");
                        break;

                }
                for (int i = 0; i < 11; i += 1)
                {
                    int[] values = new int[i];

                    Metodos.RandomFill(values);
                    //para el contador e imprime el resultado:
                    DateTime tiempo1 = DateTime.Now;

                    switch (j)
                    {
                        case 0:
                            cont = Metodos.Burbuja(values);
                            break;
                        case 1:
                            cont = Metodos.InsercionDirecta(values);
                            break;
                        case 2:
                            cont = Metodos.InsercionBinaria(values);
                            break;
                        case 3:
                            cont = Metodos.ShellSort(values);
                            break;
                        case 4:
                            cont = Metodos.quicksort(values, 0, values.Length -1);
                            break;
                        case 5:
                            cont = Metodos.ShakerSort(values);
                            break;
                        case 6:
                            cont = Metodos.MergeSort(values);
                            break;

                    }

                    DateTime tiempo2 = DateTime.Now;

                    TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

                    Console.WriteLine(i.ToString().PadRight(6) + "| " + total.ToString().PadRight(17) + "| " + cont.ToString().PadRight(10));
                    sw.WriteLine(i.ToString() + ", " + total.ToString() + ", " + cont.ToString());

                }

            }

            sw.Close();

        }
    }
}
