using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientarObjetoC.Polimorfismo
{
    internal class Estagiario : Imposto
    {
        double salario;
        public Estagiario(double salario)
        {
            this.salario = salario;
        }

        public override void valeAlimentacao()
        {
            Console.WriteLine("Desconto gerente padrão vale alimentação " + (salario * 0.10));
        }
        public override void valeTransporte()
        {
            Console.WriteLine("Desconto gerente padrão vale transporte " + (salario * 0.07));
        }

    }
}
