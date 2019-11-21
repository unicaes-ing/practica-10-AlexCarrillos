using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA100
{
    //Carrillos Gaitan 22/10/2019
//Elaborar un programa que capture por teclado una contraseña de 7 a 20 caracteres de
//longitud y que la almacene de manera cifrada en un archivo de texto. (Nota: escriba su propio
//algoritmo para cifrar la contraseña, por ejemplo: puede hacer uso de Replace para sustituir algunos
//caracteres por otros)
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.Clear();
                Console.Write("**====**MENU**====**" +
                    "\n\n1-Registrarse." +
                    "\n2-Salir." +
                    "\n Ingresar opcion: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Registrarse();
                        break;

                    case 2:
                        Environment.Exit(1);
                        break;
                }
            } while (menu != 3);
        }
        public static void Registrarse()
        {
            StreamWriter Registro = new StreamWriter("Registro_Usua.txt", true);
            bool usuario = false;
            bool contra = false;
            bool veri = false;
            string Nombre, Contraseña, Verificacion;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingresar lo siguiente: ");
                Console.Write("Nombre de usuario: ");
                Nombre = Console.ReadLine();
                if (Nombre == "")
                {
                    Console.WriteLine("Llene el resgistro anterior");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario a sido registrado exitosamente");
                    Console.ReadKey();
                    usuario = true;
                }
            } while (usuario == false);
            do
            {
                Console.Clear();
                Console.WriteLine("Nombre de Usuario: {0}", Nombre);
                Console.Write("Contraseña: ");
                Contraseña = Console.ReadLine();
                if (Contraseña.Length < 7 || Contraseña.Length > 20)
                {
                    Console.Write("\nLa contraseña debe tener un rango de 7 a 20 caracteres");
                    Console.ReadKey();
                }
                else
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Nombre de Usuario {0}", Nombre);
                        Console.Write("\nConfirme su contraseña: ");
                        Verificacion = Console.ReadLine();
                        if (Verificacion.Equals(Contraseña))
                        {
                            Console.WriteLine("Su contraseña fue confirmada exitosamente");
                            Console.ReadKey();
                            veri = true;
                            contra = true;
                        }
                        else
                        {
                            Console.Write("\n\nLa contraseña no es correcta");
                            Console.ReadKey();
                        }
                    } while (veri == false);
                    Console.WriteLine("\nReturning...");
                    Thread.Sleep(600);
                }
                Registro.WriteLine("{0}:{1}", Nombre, Contraseña);
                Registro.Close();
            } while (contra == false);
        }

    }
}

