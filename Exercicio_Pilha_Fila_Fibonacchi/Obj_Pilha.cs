using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pilha_Fila_Fibonacchi
{
    internal class Obj_Pilha
    {
        int num;
        Obj_Pilha? proximo;
        public Obj_Pilha()
        {

        }

        public Obj_Pilha(int num)
        {
            this.num = num;
        }

        public override string? ToString()
        {
            return $" {this.num} ";
        }

        public void Set_Proximo(Obj_Pilha below_object)
        {
            this.proximo = below_object;
        }

        public Obj_Pilha Get_Proximo()
        {
            return proximo;
        }

        public int Get_num()
        {
            return num;
        }
    }
}
