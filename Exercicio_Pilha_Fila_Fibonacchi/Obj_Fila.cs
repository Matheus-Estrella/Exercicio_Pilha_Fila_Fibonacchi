using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pilha_Fila_Fibonacchi
{
    internal class Obj_Fila
    {
        int num;
        Obj_Fila? next;
        Obj_Fila? before;

        public Obj_Fila(int num)
        {
            this.num = num;
        }
        public void Set_Next(Obj_Fila o)
        {
            this.next = o;
        }
        public Obj_Fila? Get_Next()
        {
            return this.next;
        }
        public Obj_Fila? Get_Before()
        {
            return this.before;
        }
        public override string? ToString()
        {
            return $" {this.num} ";
        }
    }
}
