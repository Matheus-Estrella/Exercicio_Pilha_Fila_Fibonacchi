using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pilha_Fila_Fibonacchi
{
    internal class Fila
    {
        Obj_Fila? head;
        Obj_Fila? tail;

        public Fila()
        {
            this.head = null;
            this.tail = null;
        }
        bool Is_Empty()
        {
            return (head == null && tail == null);
        }

        public void Push(Obj_Fila o)
        {
            if(Is_Empty())
            {
                this.head = this.tail = o;
            }
            else
            {
                tail.Set_Next(o);
                tail = o;
            }
        }
        public void Pop()
        {
            if(!Is_Empty())
            {
                if(head == tail)
                {
                    this.head = this.tail = null;
                }
                else
                {
                    this.head = head.Get_Next();
                }
            }
        }
        public void Print()
        {
            Obj_Fila fila = this.head;
            do
            {
                Console.Write(fila.ToString());
                fila = fila.Get_Next();
            } while (fila != null);
        }
    }
}
