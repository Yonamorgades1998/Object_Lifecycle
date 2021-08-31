//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;
using System.Linq;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            

            // AL INTENTAR CREAR ESTE NUMERO DE INSTANCIAS EXCEDO EL LIMITE DE CAPACIDAD DE ALMACENAMIENTO DE LA MEMORIA 
            // POR LO QUE LLEGADO A UN NUMERO NO ME GENERA NUEVAS INTANCIAS
            // foreach (int value in Enumerable.Range(1, 1000000)){
            //     new Train("tren1");
            // }

            // Console.WriteLine(Train.GetCount());

            Train t1= new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            // POR MAS QUE LAS INSTANCIAS POSEAN LOS MISMOS ATRIBUTOS CADA INSTANCIA ES UNICA, POR LO QUE LA COMPARACION NUNCA VA A SER VERDADERA 
            if ( t1==t2 ){
                Console.WriteLine("t1 y t2 son iguales");
            }
            if ( t2 == t3){
                Console.WriteLine("t2 y t3 son iguales");
            }

            
            // Console.WriteLine("Hello World!");
        }
    }
}