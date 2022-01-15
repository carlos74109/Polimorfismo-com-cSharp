using OrientarObjetoC.Classe;
using OrientarObjetoC.Polimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientarObjetoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instaciar estagiario
            Imposto estagiario = new Estagiario(1000);
            estagiario.valeAlimentacao();
            estagiario.valeTransporte();
            Console.WriteLine("----------");
            //Instaciar Gerente
            Imposto gerente = new gerente(4000);
            gerente.valeTransporte();
            gerente.valeAlimentacao();
            Console.WriteLine("-----------");
            //Instanciar Atendente
            Imposto atendente = new Atendente(3500);
            atendente.valeTransporte();
            atendente.valeAlimentacao();



        }
       
    }
}
