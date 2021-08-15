using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir un diccionario
            Dictionary<string, float> Nombres = new Dictionary<string, float>();
            //agregar elementos al diccionario
            Nombres.Add("Nathaly", 18f);
            Nombres.Add("Haydee", 47f);
            Nombres.Add("Fatima", 1f);

            //leer diccionario y mostrar datos
            foreach (KeyValuePair<string, float> Nm in Nombres)
            {
                Console.WriteLine("Key: {0}, Value: {1}", Nm.Key, Nm.Value);
            }


            //ordenar diccionario
            //definir diccionario como una lista
            var ordenar = Nombres.Keys.ToList();
            ordenar.Sort();
            Console.WriteLine("Diccionario ordenado");
            foreach (var T in ordenar)
            {
                Console.WriteLine("Key: {0}, Value: {1}", T, Nombres[T]);
            }


            Console.ReadKey();
        }
    }
       
    }

