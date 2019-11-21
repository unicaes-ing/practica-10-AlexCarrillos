using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA100
{
    class Ejercicio4
    {
        //Carrillos Gaitan 22/10/2019
//        Crear un programa de acceso, para que el usuario ingrese por teclado la contraseña y la
//compare con la contraseña cifrada almacenada en el archivo texto del ejercicio anterior, que
//le permita intentarlo 3 veces, de lo contrario que impida el acceso al programa.
        static void Main(string[] args)
        {
            string usuario, contra, veri;
            int inten = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Inicia sesion: ");
                Console.Write("Nombre de Usuario: ");
                usuario = Console.ReadLine();
                Console.Write("Contraseña: ");
                contra = Console.ReadLine();
                veri = usuario + ":" + contra;
                if (Veri(veri) == true)
                {
                    Console.WriteLine("Correcto...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Error...");
                    Console.ReadKey();
                    inten++;
                }
            } while (inten != 3);
            if (inten == 3)
            {
                Console.WriteLine("Sistema bloqueado...");
                Console.ReadLine();
            }
        }
        static bool Veri(string Contra)
        {
            string buscar;
            bool verdad = false;
            StreamReader Buscar = new StreamReader("Registro_Usua.txt");
            do
            {
                buscar = Buscar.ReadLine();
                if (buscar == Contra)
                {
                    verdad = true;
                }
            } while (buscar != null);
            return verdad;
        }
    }
}
