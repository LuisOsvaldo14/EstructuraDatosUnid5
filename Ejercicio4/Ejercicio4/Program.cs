

class Ejercicio4
{
    static void Main()
    {
        Queue<int> cola = new Queue<int>();
        cola.Enqueue(100);
        cola.Enqueue(200);
        cola.Enqueue(300);
        cola.Enqueue(400);
        cola.Enqueue(500);

        Console.Write("Contenido de la cola: ");
        foreach (int n in cola)
        {
            Console.Write(n+ ", ");
        }
    }
}