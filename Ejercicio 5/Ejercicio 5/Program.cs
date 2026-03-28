

class Ejercicio5
{
    static void Main()
    {
        Queue<int> cola = new Queue<int>();
        cola.Enqueue(100);
        cola.Enqueue(200);
        cola.Enqueue(300);
        cola.Enqueue(400);
        cola.Enqueue(500);
        int Acumular = 0;
        Console.Write("La suma de los valores ");
        foreach (int n in cola)
        {
            Acumular = n + Acumular;
            Console.Write(n + "," );
        }
        Console.WriteLine($"es igual a {Acumular}");

    }
}
