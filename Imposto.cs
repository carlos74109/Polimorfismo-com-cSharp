using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientarObjetoC.Polimorfismo
{
   abstract internal class Imposto
    {
        double salario;
        public virtual void valeAlimentacao()
        {
            Console.WriteLine("Desconto padrão vale alimentação " + (salario * 0.1));
        }

        public virtual void valeTransporte()
        {
            Console.WriteLine("Desconto padrão vale transporte " + (salario * 0.6));
        }
    }
}
