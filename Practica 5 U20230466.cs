using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****Calculadora de promedio universitario *****");

            // Solicitando al estudiante que ingrese las notas del primer computo
            Console.WriteLine("\nIngrese las notas del primer computo");
            Console.WriteLine("\nIngrese la nota del laboratorio 1: ");
            double Lab1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del parcial 1: ");
            double Parc1 = Convert.ToDouble(Console.ReadLine());


            // Solicitando al estudiante que ingrese las notas del primer computo
            Console.WriteLine("\nIngrese las notas del segundo computo");
            Console.WriteLine("\nIngrese la nota del laboratorio 2: ");
            double Lab2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del parcial 2: ");
            double Parc2 = Convert.ToDouble(Console.ReadLine());


            // Solicitando al estudiante que ingrese las notas del primer computo
            Console.WriteLine("\nIngrese las notas del tercer computo");
            Console.WriteLine("\nIngrese la nota del laboratorio 1: ");
            double Lab3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del parcial 3: ");
            double Parc3 = Convert.ToDouble(Console.ReadLine());

            // Calcular el Promedio
            double PromedioLab = (Lab1 + Lab2 + Lab3) * 0.60;
            double PromedioParc = (Parc1 + Parc2 + Parc3) * 0.40;
            double NotaFinal = (PromedioLab / 3) + (PromedioParc / 3);

            Console.WriteLine("\nSu nota final es de: " + Math.Round(NotaFinal, 1));

            // Comparacion de la nota Final
            if (NotaFinal >= 7)
            {
                Console.WriteLine("\nUsted paso la materia con excelente nota.\n");
            }

            else if (NotaFinal >= 6)
            {
                Console.WriteLine("\nUsted paso la materia con nota baja.\n");
            }

            else
            {
                Console.WriteLine("\nUsted paso la materia con excelente nota.\n");
            }
            Console.ReadKey();

        }
    }
}