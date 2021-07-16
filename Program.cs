using System;

namespace Blockchain
{
    class Program
    {
        static void Main()
        {
            Sequence blockchain = new Sequence("Genesis")
            {
                "Teste 1",
                "Teste 2",
                "Teste 3",
                "Teste 4",
                "Teste 5"
            };

            // lista
            foreach (var b in blockchain)
                Console.WriteLine(b);

            // verifica blocos individualmente
            for (int i = 0; i < blockchain.Count; i++)
                Console.WriteLine($"Block #{i} = {(Block.Validate(blockchain[i]) ? "válido" : "inválido")}");
            Console.WriteLine("Blocos individualmente válidos!");

            // verifica sequência
            blockchain.Validate();
            Console.WriteLine("Sequência válida!");

            try
            {
                // remove 1
                // blockchain.RemoveAt(new Random().Next(blockchain.Count));
                // blockchain.RemoveAt(0);
                blockchain.RemoveAt(2);
                Console.WriteLine("Remove um item da sequência.");

                // verifica sequência
                blockchain.Validate();
                Console.WriteLine("Sequência válida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
