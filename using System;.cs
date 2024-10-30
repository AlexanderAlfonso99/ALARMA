using System;

class Alarma
{
    static void Main(string[] args)
    {
        // Entrada de la presión y temperatura desde la consola
        Console.Write("Ingrese la presión en libras: ");
        double presion = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la temperatura en grados Celsius: ");
        double temperatura = Convert.ToDouble(Console.ReadLine());

        // Condiciones para activar la alarma
        if (presion >= 35 || (temperatura > 75 && temperatura < 95))
        {
            Console.WriteLine("Alarma encendida.");
        }
        else
        {
            Console.WriteLine("Alarma apagada.");
        }

        // Final del programa
        Console.WriteLine("Presione cualquier tecla para finalizar.");
        Console.ReadKey();
    }
}

