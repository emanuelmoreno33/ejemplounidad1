using System;
using System.Collections.Generic;

namespace ejemplo
{
    public class Elemento
    {
        public string Nombre { get; set; }
        public int  Puntacion { get; set; }
        public string Tipo { get; set; } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int vidas = 3;
            int frutas = 0;
            int puntos = 0;
            List<Elemento> elementos = new List<Elemento>()
            {
                new Elemento(){Nombre="platano",Puntacion=1,Tipo="objetivo"},
                new Elemento(){Nombre="manzana",Puntacion=1,Tipo="objetivo"},
                new Elemento(){Nombre="pera",Puntacion=1,Tipo="objetivo"},
                new Elemento(){Nombre="uva",Puntacion=1,Tipo="objetivo"},
                new Elemento(){Nombre="durazno",Tipo="no objetivo"},
                new Elemento(){Nombre="fresa",Tipo="no objetivo"},
                new Elemento(){Nombre="aguacate",Tipo="verdura"},
            };

            Random aleatorio = new Random();
            List<int> anteriores = new List<int> {};
            int valor;
            bool bandera = false;

            Console.WriteLine("Hello World!");
            Console.ReadLine();
            while(vidas >0 && anteriores.Count < 7 )
            {
                valor = aleatorio.Next(7);
                Console.WriteLine(valor.ToString());
                foreach (int revisar in anteriores)
                {
                    if(valor == revisar)
                    {
                        bandera = true;
                    }
                }
                anteriores.Add(valor);
                if (bandera == false)
                {
                    Console.WriteLine("obtuviste: " + elementos[valor].Nombre + " que es?");

                    Console.WriteLine("objetivo, no objetivo o verdura");
                    string respuesta = Console.ReadLine();
                    if(respuesta == elementos[valor].Tipo)
                    {
                        Console.WriteLine("correcto");
                        if(elementos[valor].Tipo == "objetivo")
                        {
                            frutas++;
                            puntos += elementos[valor].Puntacion;
                        }
                    }
                    else
                    {
                        Console.WriteLine("incorrecto");
                        vidas--;
                        Console.WriteLine("tienes " + vidas.ToString());
                    }    
                }
                bandera = false;

            }
            Console.WriteLine("fin del juego");
            Console.ReadLine();
        }
    }
}
