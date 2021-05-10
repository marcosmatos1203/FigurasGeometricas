using System;
using FigurasGeometricas.Controlador;
using FigurasGeometricas.Dominio;

namespace FigurasGeometricas.Tela
{
    public class TelaTriangulo
    {
        
        ControladorTriangulo ct = new ControladorTriangulo();
        Triangulo triangulo = new Triangulo();
        public TelaTriangulo(ControladorTriangulo controladorTriangulo)
        {
            ct = controladorTriangulo;
        }
        public void NovoTriangulo()
        {
            Console.WriteLine ("Tipo de Triangulo");
            Console.WriteLine("");

            bool conseguiuQualificar = RegistraTriangulo();

            if (conseguiuQualificar)
                Console.WriteLine($"Triangulo {ct.tipoTriangulo}");
            Console.ReadLine();
        }
        private bool RegistraTriangulo()
        {
            string resultadoValidacao;
            bool conseguiuGravar = true;

            Console.Write("Digite o ladoA: ");
            int ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ladoB: ");
            int ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ladoC: ");
            int ladoC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            resultadoValidacao = ct.QualificaTriangulo(ladoA,ladoB, ladoC);

            if (resultadoValidacao != "TRIANGULO_VALIDO")
            {
                Console.WriteLine("Triangulo Inválido");
                conseguiuGravar = false;
            }
            return conseguiuGravar;
        }
    }
}
