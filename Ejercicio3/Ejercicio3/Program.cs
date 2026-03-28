using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        Stack<string> pila = new Stack<string>(new[] { "Jose", "Luis", "Ismael" });

        VaciarYMostrar(pila);
    }

    static void VaciarYMostrar(Stack<string> p)
    {
        Console.WriteLine("Eliminando elementos...");
        while (p.Count > 1)
        {
            p.Pop(); 
        }
        Console.WriteLine("Elementos actuales: ");
        foreach (string s in p) Console.WriteLine(s);
    }
}