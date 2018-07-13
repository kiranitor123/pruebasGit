using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace pruebasGit
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("soy .netcore 2.1");
        }

        public static List<Persona> Data(){
            List<Persona> Lista;
             Lista= new List<Persona>{
                      new Persona{Nombre="Wilson",Apellido="PC"},
                       new Persona {Nombre="GALLO",Apellido="gALLINA"}
             };
         return new List<Persona>();
        }
    }
}
