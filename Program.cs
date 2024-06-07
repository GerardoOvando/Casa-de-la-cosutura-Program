using System;
using System.Collections.Generic;
using System.IO;

namespace PracticandoTodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 10;

            
            Dictionary<int, string> Dic = new Dictionary<int, string>();


            StreamWriter datos = new StreamWriter(@"E:\Cursos\CURSO DE C#\Practicas\PracticandoTodo\BBDDregistres.txt");
            StreamReader lee = new StreamReader(@"E:\Cursos\CURSO DE C#\Practicas\PracticandoTodo\BBDDregistres - Copy.txt");

            string data;
            string record;
            
            Cliente cliente = new Cliente();
            do
            {
                
                Console.Clear();

                Console.Title = "Casa de la Costura Program";
                Console.Write("Casa de la Costura                                                        ");
                Console.WriteLine(DateTime.Now + "\n");
                

                Console.WriteLine("¿Qué deseas realizar? \n");
                Console.WriteLine(
                    "1) Registrar nuevo cliente o pedido.\n" +
                    "2) Revisar calendario.\n" +
                    "3) Revisar base de datos.\n" +
                    "0) Para salir del programa.");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingresaste una entrada no valida, se tomará como opción 10");
                    opcion = 10;
                    Console.ReadKey();
                }
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Seleccionaste: Registrar nuevo cliente.\n");
                        cliente.ID = cliente.ID + 1;
                        Console.WriteLine("Ingresa el nombre del cliente");
                        cliente.NOMBRE = Console.ReadLine();
                        Console.WriteLine("Ingresa el número teléfonico");
                        cliente.PHONE = Convert.ToString(Console.ReadLine());

                        record = cliente.ID + ", " + cliente.NOMBRE + ", " + cliente.PHONE + ", " + cliente.REGISTRO;
                        datos.WriteLine(record);
                        
                        Dic.Add(cliente.ID, cliente.NOMBRE);
                        

                        opcion = 10;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Seleccionaste: Revisar base de datos. \n Lista de clientes: \n");
                        foreach (KeyValuePair<int, string> kvp in Dic)
                        {
                            Console.WriteLine(kvp);

                        }
                        Console.WriteLine("\n");
                        
                        
                        while((data = lee.ReadLine())!= null ) Console.WriteLine(data);


                        Console.WriteLine("Presiona cualquier tecla para salir al menú principal");
                        


                        Console.ReadKey();

                        opcion = 10;

                        break;
                }
            } while (opcion != 0);
            datos.Close();
            lee.Close();



        }
    }
    class Cliente
    {
        private int id = 0;
        private string nombre;
        private string phone;
        private DateTime registro = DateTime.Now;
        
        public int ID { get => this.id; set => this.id = value; }
        public string NOMBRE { get => this.nombre; set => this.nombre = value; }
        public string PHONE { get => this.phone; set => this.phone = value; }
        public DateTime REGISTRO { get => this.registro; set => this.registro = value; }
    }
}
