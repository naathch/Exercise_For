using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por @naathch
  
            Console.WindowHeight = 30; // alto de la ventana 
            Console.WindowWidth = 70; //ancho de la ventana 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Conversiones de segundos a semanas, dias, horas y minutos";
            Console.Write("\n\n");
            // Declaracion de variables 
            int semanas, dias, horas, minutos, segundos, acu;
            // Entrada 
            Console.Write("\tConversiones de tiempo...");
            Console.Write("\n");
            Console.Write("\tIntroduzca la cantidad en segundos [entero] : ");
            acu = int.Parse(Console.ReadLine());
            Console.Write("\n");
            //Procesos 
            segundos = acu % 60;
            acu = acu / 60;
            minutos = acu % 60;
            acu = acu / 60;
            horas = acu % 24;
            acu = acu / 24;
            dias = acu % 7;
            semanas = acu / 7;
           //Salida 
            Console.WriteLine("\t**************************************************");
            Console.WriteLine("\tSegundos en semanas,dias,horas,minutos y segundos ");
            Console.WriteLine("\tNumero de semanas: " + semanas);
            Console.WriteLine("\tNumero de dias:	" + dias);
            Console.WriteLine("\tNumero de horas:	" + horas);
            Console.WriteLine("\tNumero de minutos: " + minutos);
            Console.WriteLine("\tNumero de segundos: " + segundos);
            Console.Write("\n");
            //Pantalla opcional 
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t	Este programa fue diseñado por:	");
            Console.WriteLine("\t	@naathch	");    
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
    }
}
