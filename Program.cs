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
            Console.WriteLine("XD XD XD XD");
         
            var suma=1;
            for(int i=0;i<10;i++){
                Console.WriteLine(suma+"+"+i+"="+(suma+i) );
            }
            foreach(var per in Data()){
                Console.WriteLine($"{per.Nombre} {per.Apellido}");

            }
            
        }

        public static List<Persona> Data(){
            List<Persona> Lista;
             Lista= new List<Persona>{
                    new Persona{Nombre="Wilson",Apellido="PC"},
                    new Persona {Nombre="GALLO",Apellido="gALLINA"},
                    new Persona {Nombre="Bruce",Apellido="Wayne"},
                    new Persona {Nombre="Elver",Apellido="Galarga"}
             };
         return Lista;
        }
    }
}
