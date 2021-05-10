using System;
using System.Collections.Generic;
using System.Text;

namespace FigurasGeometricas.Dominio
{
    public class Triangulo
    {
        public int ladoA, ladoB, ladoC;

        public string Validar()
        {
            string resultadoValidacao = "";

            if (ladoA > ladoB + ladoC || ladoB > ladoA + ladoC || ladoC > ladoA + ladoB)
                resultadoValidacao = "Triangulo Inválido";


            if (string.IsNullOrEmpty(resultadoValidacao))
                resultadoValidacao = "TRIANGULO_VALIDO";

            return resultadoValidacao;
        }
    }
}
