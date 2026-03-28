using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>(new[] { 1, 2, 3, 4, 5 });

        VaciarYMostrar(pila);
    }

    static void VaciarYMostrar(Stack<int> pila)
    {
        Console.WriteLine("Eliminando elementos...");
        while (pila.Count > 0)
        {
            pila.Pop();
        }
        Console.WriteLine("La pila se ha vaciado. Elementos actuales: " + pila.Count);
    }
}
