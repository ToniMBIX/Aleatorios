using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] list = new int[20];
        for (int i = 0; i < 20; i++)
        {
            list[i] = rand.Next(100);
        }

        Console.Write("Ingresa un número del 0 al 99: ");
        int number = int.Parse(Console.ReadLine());

        int counter = 0;
        foreach (int n in list)
        {
            if (n == number)
            {
                counter++;
            }
        }

        Console.WriteLine("El número {0} aparece {1} veces en la lista generada.", number, counter);
    }
}
