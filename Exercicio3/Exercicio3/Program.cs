namespace Exercicio3 {
    internal class Program {
        static void Main(string[] args) {
            int INDICE = 12, SOMA = 0, K = 1;

            for (int i = 0; i < INDICE; i++) {
                K++;
                SOMA += K;
            }

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
