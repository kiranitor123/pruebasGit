using System;
<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using System.Linq;
=======
using Linq;
>>>>>>> f782738d54a42707c30231f0474fe97a027f7fc4

namespace pruebasGit
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("soy .netcore 2.1");
            
            var suma=1;
            for(int i=0;i<10;i++){
                Console.WriteLine(suma+"+"+i+"="+(suma+i) );
            }
            
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
