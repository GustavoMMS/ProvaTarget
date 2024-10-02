namespace Exercicio1 {
    internal class Program {
        static void Main(string[] args) {
            int[] fibo = new int[20];

            fibo[0] = 0;
            fibo[1] = 1;

            for (int i = 2; i < 20; i++) {
                fibo[i] = (fibo[i - 1] + fibo[i - 2]);
            }

            Console.Write("Entre com um número: ");
            int n = int.Parse(Console.ReadLine());

            bool verifica = false;
            int j = 0;

            do {
                if (fibo[j] == n) {
                    Console.WriteLine(n + "  faz parte da sequência de fibonacci!");
                    verifica = true;
                } else {
                    verifica = false;
                }

                j++;
            } while (!verifica && j < 20);

            if (!verifica) {
                Console.WriteLine("O numero informado não faz parte da sequência de fibonacci!");
            }
        }
    }
}
