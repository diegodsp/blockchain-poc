using Blockchain;
using NUnit.Framework;

namespace BlockchainPoc
{
    public class Tests
    {
        private Sequence Blockchain { get; set; }

        [SetUp]
        public void Setup()
        {
            this.Blockchain = new Sequence("Genesis") {
                "Teste 1",
                "Teste 2",
                "Teste 3",
                "Teste 4",
                "Teste 5"
            };
        }

        [TestCase(0)]
        [TestCase(2)]
        public void RemoveUmItem(int idx)
        {
            this.Blockchain.RemoveAt(idx);
            this.Blockchain.Validate();
            // Assert.Pass();
        }

        [TestCase(3, "Teste alterado")]
        public void AlteraUmItem(int idx, string content)
        {
            this.Blockchain[idx].Content = content;
            this.Blockchain.Validate();
        }
    }
}