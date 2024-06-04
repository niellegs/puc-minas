class Program {
    static void Main(string[] args)
    {
        int[,] Matriz = new int[5,5]; // Declaração da Matriz
        int[] VetorResultante = new int[5]; // Declaração do vetor resultante

        for(i = 0; i < 5; i++) // Para cada linha da matriz
        {
            for(int j = 0; j < 5; j++)  // Para cada coluna da matriz
            {
                Console.Write($"Elemento {i + 1}, {j+ 1 }: ");

                Matriz[i, j] = int.Parse(Console.Readline()); // Lê o valor do elemento
            }
        }

        // Chamada à Função
        // Envia a Matriz e recebe como resultado um vetor

        ValorResultante = ExtraiDiagPrinc(Matriz)

        // Agora é só mostrar

        Console.Write("\n\ Diagonal principal: ");

        for(int i=0; i < 5; i++) // Para cada coluna da Matriz
        {
            Console.Write(${VetorResultante[i,7]})
        }

        Console.WriteLine("/n");
        Console.ReadKey();

    }

    static int[] ExtraiDiagPrinc(int[], M) 
    {
        int[] Result = new int[5];
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if(i == j) 
                    Result[i] = M[i ,j]
            }
        }

        // Retornando
        return Result;
    }
}

