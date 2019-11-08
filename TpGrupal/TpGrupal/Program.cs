using System;
using System.Collections;
using System.Linq;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(); // mientras que showMenu sea igual a MainMenu
            }
            Console.ReadLine();
        }

        private static bool MainMenu() //opciones de menu
        {
            Console.Clear();
            Console.WriteLine("Seleccione una de las opciones:");
            Console.WriteLine("1) Invertir lo escrito");
            Console.WriteLine("2) Eliminar los espacios");
            Console.WriteLine("3) Averiguar si es palindromo");
            Console.WriteLine("4) Salir del programa");
            Console.Write("Seleccione una de las opciones: ");

            switch (Console.ReadLine()) // la opcion que elige
            {
                case "1":
                    InvertirOracion(); //lleva a la funcion invertir oracion
                    return true;
                case "2":
                    EliminarEspacios(); //lleva a la funcion eliminar espacios
                    return true;
                case "3":
                    EsPalindromo(); //lleva a la funcion es palindromo
                    return true;
                case "4":
                    return false; //sale del programa
                default:
                    return true;
            }
        }

        private static void InvertirOracion()
        {
            Console.Clear(); //limpia la consola
            Console.WriteLine("Invertir la oracion");

            char[] charArray = CapturarOracion().ToCharArray(); //la oracion lo convierte en una cadena de caracteres y lo guarda en charArray
            Array.Reverse(charArray); //al charArray le da la vuelta 
            MostrarResultado(String.Concat(charArray)); //muestra el charArray que fue cocatenado
        }

        private static void EliminarEspacios()
        {
            Console.Clear(); //limpia la consola
            Console.WriteLine("Elimine los espacios");

            MostrarResultado(CapturarOracion().Replace(" ", "")); // reemplaza los espacios por nada(elimina) y luego lo muestra
        }

        private static void MostrarResultado(string message) // funcion para que muestre resultado que recibe un parametro en string
        {
            Console.WriteLine("\nSu oracion modificada es: {0}", message);
            Console.WriteLine("\nPresione enter para volver al menu");
            Console.ReadLine();
        }

        private static string CapturarOracion() //lee la oracion o palabra que vas a usar
        {
            Console.Write("\nIngrese la oracion: ");
            return Console.ReadLine();
        }

        private static void EsPalindromo()
        {
            Console.Clear();
            Console.WriteLine("¿Es Palindromo?");

            string palabra = CapturarOracion(); //la oracion que se escribio se guarda en palabra          

            char[] charPalabra = palabra.ToCharArray(); //la oracion lo convierte en una cadena de caracteres y lo guarda en charPalabra
            Array.Reverse(charPalabra); //al charPalabra le da la vuelta           

            if (palabra.Equals(String.Concat(charPalabra))) //verifica si palabra es igual a charPalabra que fue convertido nuevamente de char a string
            {
                Console.WriteLine("\nSu oracion modificada es: {0}", String.Concat(charPalabra)); //muestra de resultado                
                Console.WriteLine("\nEs palindromo");
                Console.WriteLine("\nPresione enter para volver al menu");

            }
            else //si no entra en el primer if significa que no es palindromo
            {
                Console.WriteLine("\nSu oracion modificada es: {0}", String.Concat(charPalabra)); //muestra de resultado                
                Console.WriteLine("\nNo es palindromo");
                Console.WriteLine("\nPresione enter para volver al menu");

            }
            Console.ReadLine();
        }
    }
}



