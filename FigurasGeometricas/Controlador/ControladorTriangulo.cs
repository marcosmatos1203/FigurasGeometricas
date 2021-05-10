using FigurasGeometricas.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigurasGeometricas.Controlador
{
    public class ControladorTriangulo
    {
        public string tipoTriangulo;
        Triangulo triangulo = new Triangulo();
        public string QualificaTriangulo(int ladoA, int ladoB, int ladoC)
        {


            if (ladoA == ladoB && ladoA == ladoC)
            {
                tipoTriangulo = "Equilatero";
            }
            else if (ladoA == ladoB && ladoA != ladoC || ladoA == ladoC && ladoA != ladoB || ladoC == ladoB && ladoC != ladoA)
            {
                tipoTriangulo = "Isósceles";
            }
            else if(ladoA != ladoB && ladoA != ladoC)
                tipoTriangulo = "Escaleno";

            triangulo.ladoA = ladoA;
            triangulo.ladoB = ladoB;
            triangulo.ladoC = ladoC;
            
            string resultadoValidacao = triangulo.Validar();

            return resultadoValidacao;
        }
    }
}
