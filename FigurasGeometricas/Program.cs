using FigurasGeometricas.Controlador;
using FigurasGeometricas.Tela;
using System;

namespace FigurasGeometricas
{
    class Program
    {
        
        static void Main(string[] args)
        
        {
            ControladorTriangulo controlador = new ControladorTriangulo();
            TelaTriangulo telaT = new TelaTriangulo(controlador);
            telaT.NovoTriangulo();
        }
    }
}
