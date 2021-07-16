using System;

namespace Blockchain
{
    class Program
    {
        static void Main()
        {
            // criação
            Console.WriteLine("Cria blocos...");
            Sequence blockchain = new Sequence("Genesis")
            {
                "Teste 1",
                "Teste 2",
                "Teste 3",
                "Teste 4",
                "Teste 5"
            };

            // listagem
            Console.WriteLine("Lista blocos...");
            foreach (var b in blockchain)
                Console.WriteLine(b);

            // verifica blocos individualmente
            Console.WriteLine("Verifica blocos individualmente...");
            for (int i = 0; i < blockchain.Count; i++)
                Console.WriteLine($"Bloco #{i} = {(Block.Validate(blockchain[i]) ? "válido" : "inválido")}");

            try
            {
                // verifica sequência
                Console.Write("Verifica sequência: ");
                blockchain.Validate();
                Console.WriteLine("válida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"inválida! Erro: {ex.Message}");
            }

            // remove um item
            Console.WriteLine("Remove um item da sequência...");
            // remove um aleatório
            // blockchain.RemoveAt(new Random().Next(blockchain.Count));
            // remove o primeiro
            // blockchain.RemoveAt(0); // problema, pois a sequência continua válida
            // remove um do meio
            blockchain.RemoveAt(2);  // funciona, pois perde-se a sequência de chaves

            try
            {
                // verifica sequência
                Console.Write("Verifica sequência: ");
                blockchain.Validate();
                Console.WriteLine("válida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"inválida! Erro: {ex.Message}");
            }
        }
    }
}
