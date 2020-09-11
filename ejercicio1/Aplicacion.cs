using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio1
{
    class Aplicacion
    {
        public Aplicacion()
        {
            RecibirPromedio();
        }
        public Promedio ObtenerPromedio()
        {
            Console.WriteLine("Digite la nota 1");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 2");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 3");
            float nota3 = float.Parse(Console.ReadLine());
            Promedio promedio = new Promedio(nota1,nota2,nota3);
            return promedio;
        }

        public void RecibirPromedio()
        {
            Promedio promedio = ObtenerPromedio();
            string mensaje = promedio.ObtenerResultadoDelPromedio();
            Console.WriteLine(mensaje);
        }
    }
}
