using System;
using System.Collections.Generic;

class Ejercicio1
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();
        pila.Push(10);
        pila.Push(20);
        pila.Push(30);
        pila.Push(40);

        Console.WriteLine("Contenido de la pila (del último al primero):");
        foreach (int numero in pila)
        {
            Console.WriteLine(numero);
        }
    }
}
