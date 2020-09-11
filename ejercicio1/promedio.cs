using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio1
{
    class Promedio
    {
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }

        public Promedio(float nota1,float nota2,float nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
          

        public float ObtenerPromedio()
        {
           float resultado = (Nota1 + Nota2 + Nota3) / 3;
            return resultado;
        }

        public string ObtenerResultadoDelPromedio()
        {
            float resultado = ObtenerPromedio();
            
            if(resultado>=3)
            {
                return "el estudiante aprueba";
            }
            else
            {
                return "el estudiante reprueba";
            }
        }

    }
}
