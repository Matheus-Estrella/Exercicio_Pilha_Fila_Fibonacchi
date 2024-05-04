namespace Exercicio_Pilha_Fila_Fibonacchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                do
                {
                    Console.WriteLine("\nBEM VINDO A SEQUÊNCIA FIBINACCHI\nDigite uma opção:\n1-) Exercicio Filas\n2-) Exercicio Pilhas" +
                        "\n3-) Sair");
                    op = int.Parse(Console.ReadLine());
                    if ((op < 1 || op > 3))
                    {
                        Console.WriteLine("\nInsira uma opção válida");
                    }
                } while (op < 1 || op > 3);
                if (op == 1)
                {
                    Fila fila_fibonacchi = new Fila();
                    fila_fibonacchi = Popular_Fila(fila_fibonacchi);
                    Console.Write("\nOs números da sequencia Fibonacchi são: ");
                    fila_fibonacchi.Print();
                    Jump();
                } // Exercicio Filas
                if (op == 2)
                {
                    Pilha pilha_fibonacchi = new Pilha();
                    pilha_fibonacchi = Popular_Pilha(pilha_fibonacchi);
                    //pilha_fibonacchi = Inverter_Pilha(pilha_fibonacchi);
                    Console.Write("\nOs números da sequencia Fibonacchi são: ");
                    pilha_fibonacchi.Print();
                    Jump();

                } // Exercicio Pilhas
            } while (op != 3);
        }

        static int[] N_Fibonacchi()
        {
            int n = 0, prox = 1, ante = 0;
            do
            {
                Console.Write("\nDigite a quantidade de números que deseja ver da sequência Fibonacchi: ");
                n = int.Parse(Console.ReadLine());
                if (n < 1)
                {
                    Console.WriteLine("\nInsira uma opção válida");
                }
            } while (n < 1);
            int[] fibonacchi = new int[n];
            fibonacchi[0] = ante;
            fibonacchi[1] = prox;
            int aux = 0;
            for (int i = 2; i < n; i++)
            {
                aux = prox;
                prox += ante;
                ante = aux;
                fibonacchi[i] = prox;
            }
            return fibonacchi;
        }
        static Fila Popular_Fila(Fila fila)
        {
            int[] sequencia = N_Fibonacchi();
            for (int i = 0; i < sequencia.Length; i++)
            {
                fila.Push(new Obj_Fila(sequencia[i]));
            }
            return fila;
        }
        static Pilha Popular_Pilha(Pilha pilha)
        {
            int[] sequencia = N_Fibonacchi();
            for (int i = 0; i < sequencia.Length; i++)
            {
                pilha.Push(new Obj_Pilha(sequencia[i]));
            }
            return pilha;
        }
        static void Jump()
        {
            Console.WriteLine("\nAperte enter para continuar ...");
            Console.ReadKey();
            Console.Clear();
        }

        static Pilha Inverter_Pilha(Pilha pilha)
        {
            Pilha nova_pilha = new Pilha();
            Obj_Pilha x;
            while ((x = pilha.Pop()) != null)
            {
                nova_pilha.Push(x);
            }
            return nova_pilha;
        }
    }
}
