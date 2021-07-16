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

            // lista
            Console.WriteLine("Lista blocos...");
            foreach (var b in blockchain)
                Console.WriteLine(b);

            // verifica blocos individualmente
            VerificaIndividualmente(blockchain);

            // verifica sequência
            VerificaSequencia(blockchain);

            // remove um item
            RemoveUmItem(blockchain);

            // verifica individualmente
            VerificaIndividualmente(blockchain);

            // verifica sequência
            VerificaSequencia(blockchain);

            // altera um item
            AlteraUmItem(blockchain);

            // verifica individualmente
            VerificaIndividualmente(blockchain);

            // verifica sequência
            VerificaSequencia(blockchain);
        }

        static void VerificaIndividualmente(Sequence blockchain)
        {
            Console.WriteLine("Verifica blocos individualmente...");
            for (int i = 0; i < blockchain.Count; i++)
                Console.WriteLine($"Bloco #{i} = {(Block.Validate(blockchain[i]) ? "válido" : "inválido")}");
        }

        static void VerificaSequencia(Sequence blockchain)
        {
            try
            {
                Console.Write("Verifica sequência: ");
                blockchain.Validate();
                Console.WriteLine("válida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"inválida! Erro: {ex.Message}");
            }
        }

        static void RemoveUmItem(in Sequence blockchain)
        {
            // remove um item
            Console.WriteLine("Remove um item da sequência...");
            // remove um aleatório
            // blockchain.RemoveAt(new Random().Next(blockchain.Count));
            // remove o primeiro
            // blockchain.RemoveAt(0); // problema, pois a sequência continua válida
            // remove um do meio
            blockchain.RemoveAt(2);  // funciona, pois perde-se a sequência de chaves
        }

        static void AlteraUmItem(Sequence blockchain)
        {
            Console.WriteLine("Altera um item da sequência...");
            blockchain[3].Content = "Teste alterado";
        }
    }
}
