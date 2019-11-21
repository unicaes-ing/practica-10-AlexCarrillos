using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA100
{
    class Program
    {
        //Carrillo Gaitan 22/10/2019
        //Crear un programa que posea un menú con las siguientes opciones: (sin usar arreglos o colecciones)
        //1) Agregar país(añadirá al archivo de texto el nombre de un país capturado por teclado)
        //2) Mostrar países(mostrará en pantalla los países almacenadas en el archivo de texto)
        //3) Buscar país(mostrará la lista de países y el país buscado lo mostrará en otro color)
        //4) Salir
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.Clear();
                Console.Write("====MENU====" +
                    "\n1-Agregar pais" +
                    "\n2-Mostrar pais" +
                    "\n3-Buscar pais" +
                    "\n4-Salir" +
                    "\n\n Ingresar opcion: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        AggP();
                        break;
                    case 2:
                        MosP();
                        break;
                    case 3:
                        BusP();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("La opcion que escogio no es correcta");
                        Console.ReadLine();
                        break;
                }
            } while (menu != 4);
        }
        public static void AggP()
        {
            StreamWriter ArchPais = new StreamWriter("Paises_Agregados.txt", true);
            string AgregarPais;
            Console.Clear();
            Console.WriteLine("(Agregar pais)");
            do
            {
                Console.Write("Ingrese el pais que desea agregar (Ingrese 0 para salir): ");
                AgregarPais = Console.ReadLine();
                if (AgregarPais == "0")
                {
                    Console.WriteLine("\n\n\n\nCerrando...");
                    Thread.Sleep(300);
                    break;
                }
                if (AgregarPais == "")
                {
                    Console.WriteLine("Dato invalido");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    ArchPais.WriteLine(AgregarPais);
                }
            } while (AgregarPais != "0");
            ArchPais.Close();
        }
        public static void MosP()
        {
            string AllPais;
            StreamReader MostrarPais = new StreamReader("Paises_Agregados.txt");
            Console.Clear();
            Console.WriteLine("Lista de países agregados recientemente: ");
            AllPais = MostrarPais.ReadToEnd();
            Console.Write(AllPais);
            Console.Write("\n\nPresione ENTER para salir");
            Console.ReadLine();
            MostrarPais.Close();
        }
        public static void BusP()
        {
            string registro, Bpais;
            bool encontrado = false;
            Console.Clear();
            StreamReader BusPais = new StreamReader("Paises_Agregados.txt");
            Console.Write("Ingrese el pais que desea buscar: ");
            Bpais = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            do
            {
                registro = BusPais.ReadLine();
                if (Bpais.Equals(registro))
                {
                    Console.Write("\nPaís encontrado exitosamente");
                    Console.ReadLine();
                    encontrado = true;
                    break;
                }
            } while (registro != null);
            if (encontrado == false)
            {
                Console.WriteLine("\n\nNo se encontro el pais : ");
                Console.ReadLine();
            }
            BusPais.Close();
        }
    }
}

