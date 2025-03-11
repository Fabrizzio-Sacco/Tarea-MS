using System;

class Program
{
    static void Main(string[] args)
    {

        int contador = 1;
        int personaMayor = 0;
        int añoMayor = 9999; // Inicializar con un año muy antiguo o negativo

        while (contador <= 10)
        {
            Console.WriteLine($"Ingrese el año de nacimiento de la persona {contador}:");
            int año = int.Parse( Console.ReadLine() ); 
            Console.WriteLine($"Ingrese el mes de nacimiento de la persona {contador}:");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el dia de nacimiento de la persona {contador}:");
            int dia = int.Parse(Console.ReadLine());

            int edad = año + mes + dia;


            if (edad < añoMayor)
            {
                añoMayor = edad;
                personaMayor = contador;
            }

            contador++;
        }

        Console.WriteLine($"La persona mayor es la número {personaMayor}.");
        Console.ReadKey();
    }
}
