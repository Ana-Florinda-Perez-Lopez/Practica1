using System;

namespace TrianguloPascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int Count = 0;
            int Cantidad = 0;
            int Columna = 0;
            int Fila = 0;
            Console.Clear();
            Console.Write("Cuantas Filas: ");
            Cantidad = int.Parse(Console.ReadLine());
            int[,] MAT = new int[Cantidad + 1, Cantidad + 1];

            for (i = 1; i <= Cantidad; i++)
            {
                for (Count = 1; Count <= Cantidad; Count++)
                {
                    if ((Count == 1) | (i == Count))
                    {
                        MAT[i, Count] = 1;
                    }
                    else
                    {
                        MAT[i, Count] = MAT[i - 1, Count] + MAT[i - 1, Count - 1];
                    }
                }
            }

            Fila = 2;
            for (i = 1; i <= Cantidad; i++)
            {
                Columna = 40 - (i * 2);
                for (Count = 1; Count <= Cantidad; Count++)
                {
                    if (MAT[i, Count] != 0)
                    {
                        Console.SetCursorPosition(Columna, Fila);
                        Console.Write(MAT[i, Count]);
                        Columna = Columna + 4;
                    }
                }
                Fila = Fila + 1;
                Console.WriteLine();
            }
        }
    }
}
