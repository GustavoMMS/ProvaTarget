namespace Exercicio2 {
    internal class Program {
        static void Main(string[] args) {
            string str = "ana";
            string[] aux = new string[str.Length];
            int cont = 0;

            for (int i = 0; i < str.Length; i++) {
                if (str[i].ToString() == "a") {
                    cont++;
                }
            }

            Console.WriteLine(cont);
        }
    }
}
