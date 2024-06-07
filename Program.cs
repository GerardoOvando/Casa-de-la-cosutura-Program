using System;
using System.Collections.Generic;

namespace PracticandoTodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Casa de la Costura Program                        ";
            Console.Write("Casa de la Costura                   ");
            Console.WriteLine(DateTime.Now + "\n");

            Console.WriteLine("¿Qué deseas realizar? \n");
            Console.WriteLine("1) Registrar nuevo cliente o pedido.\n" +
                "2) Revisar calendario.\n" +
                "3) Revisar base de datos.");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:

                    break;
            }



        }
    }

}
