using System;

namespace RobertoCobeña3A3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; double hx = 0; double valor1;
            do
            {
                Console.Write("Introduzca el número de horas trabajadas:");
                num1 = int.Parse(Console.ReadLine());
                if (num1 > 35)
                {
                    hx = (num1 - 35);
                    valor1 = (hx * 22) + (35 * 15);
                }
                else
                {
                    valor1 = (num1 * 15);
                }
                Console.WriteLine("Su paga semanal fue de" + valor1 + "$ dolares");
                Console.WriteLine("Si desea finalizar el proceso presione 0, en caso de querer continuar vuelva a introducir sus horas trabajadas");
            } while (num1 > 0);
        }
    }
}


