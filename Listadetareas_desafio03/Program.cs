using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lista_desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[5];
            int pendientes = 0;

            while (true)
            {
                Console.WriteLine("_______");
                Console.WriteLine("Menu:");
                Console.WriteLine("1_Mostrar");
                Console.WriteLine("2_Agregar");
                Console.WriteLine("3_Eliminar");
                Console.WriteLine("4_Salir");
                Console.Write("ELige una opción:");
                int opciones = Convert.ToInt32(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        Mostrar(lista, pendientes);
                        break;
                    case 2:
                        Agregar(ref lista, ref pendientes);
                        break;
                    case 3:
                        Eliminar(ref lista, ref pendientes);
                        break;
                    case 4:
                        Console.WriteLine("Gracias por utilizar la aplicación");
                        return;
                    default:
                        Console.WriteLine("Por favor intente de nuevo.");
                        break;
                }
            }
        }
        static void Mostrar(string[] lista, int pendientes)
        {
            Console.WriteLine("_______");
            Console.WriteLine("Pendientes de la lista:");
            for (int i = 0; i < pendientes; i++)
            {
                Console.WriteLine($"{i + 1}. {lista[i]}");
            }
        }
        static void Agregar(ref string[] lista, ref int pendientes)
        {
            if (pendientes >= lista.Length)
            {
                Console.WriteLine("Su listado ya se llenó");
                return;
            }
            Console.WriteLine("_______");
            Console.Write("Ingrese una tarea: ");
            string nuevaTarea = Console.ReadLine();
            lista[pendientes] = nuevaTarea;
            pendientes++;
            Console.WriteLine("Se creo una nueva tarea.");
        }

        static void Eliminar(ref string[] lista, ref int pendientes)
        {
            if (pendientes <= 0)
            {
                Console.WriteLine("No existen tareas para eliminar.");
                return;
            }
            Console.WriteLine("_______");
            Console.Write("Ingrese la tarea que quiere eliminar: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (indice < 0 || indice >= pendientes)
            {
                Console.WriteLine("No existe la tarea.");
                return;
            }

            for (int i = indice; i < pendientes - 1; i++)
            {
                lista[i] = lista[i + 1];
            }
            pendientes--;
            Console.WriteLine("Tarea eliminada.");
        }
    }
}

