using System;

namespace PruebasMetodosOrdenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 100000; i += 100)
            {
                int[] values = new int[i];

                Metodos.RandomFill(values);
                //para el contador e imprime el resultado:
                DateTime tiempo1 = DateTime.Now;

                Metodos.Burbuja(values);
                DateTime tiempo2 = DateTime.Now;

                TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
                Console.Write("Data: " + i.ToString());
                Console.Write("\tTIEMPO: " + total.ToString());
            }





        }
    }
}
