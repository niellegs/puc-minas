class Program
{
    static void Main(string() args)
    {
        int[] Vetor = new int[5]// Declaração do Vetor

        // Entrada de elementos do vetor
        for (int i = 0; i < 5; i ++) 
        {
            console.Write($"Digite o { i + 1} Elemento do Vetor:");
            Vetor[i] = int.Parse(Console.ReadLine());
        }

        // Variaveis para a soma e para a quantidade
        int Soma;
        int Qtde;

        Soma = SomaPares(Vetor);
        Qtde = ContaÍmpares(Vetor)

            // Agora é só mostrar os resultados

        Console.WriteLine($"Soma dos números pares: {Soma}");

        Console.WriteLine($"Quantidade de Números Impares {Qtde}")

        Console.ReadKey()
    }

    // Funções

    static int SomaPares(int[] V)
    {
        int S = 0; // Variável para somar os pares
        for (int = 0; i < 5; i++) {
            if (V[i] % 2 == 0) // Ele é par?
                S+= V[i] // então acumula...
        }

        return S; // Retorna a soma
    }

    static int ContarImpares()
    {
        int Q = 0;
        for (int i = 0; i < V.Length; i++) // Para cada elemento do vetor
        {
            if (V[i] % 2 != 0) // Ele é impar?
                Q++ // Então conta...
        }
        
        return Q;
    }
}