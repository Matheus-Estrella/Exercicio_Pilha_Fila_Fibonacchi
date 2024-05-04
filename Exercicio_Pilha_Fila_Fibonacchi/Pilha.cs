using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pilha_Fila_Fibonacchi
{
    internal class Pilha
    {
        Obj_Pilha topo;

        public Pilha()
        {
            this.topo = null;
        }

        public void Push(Obj_Pilha novo_objeto)
        {
            if (Vazia())
            {
                topo = novo_objeto;
            }
            else
            {
                novo_objeto.Set_Proximo(topo);
                topo = novo_objeto;
            }

        }

        public void Print()
        {
            Obj_Pilha novo_objeto = topo;
            do
            {
                Console.Write(novo_objeto.ToString());
                novo_objeto = novo_objeto.Get_Proximo();
            } while (novo_objeto != null);
            Console.WriteLine();
        }
        public Boolean Vazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public Obj_Pilha Pop()
        {
            if (!Vazia())
            {
                Obj_Pilha x = topo;
                this.topo = topo.Get_Proximo();
                return x;
            }
            else
            {
                return null;
            }
        }
    }
}
