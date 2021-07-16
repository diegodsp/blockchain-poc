using System;
using System.Security.Cryptography;
using System.Text;

namespace Blockchain
{
    public class Block
    {
        public string PreviousHash { get; set; }
        public string Content { get; set; }
        public string Hash { get; set; }

        public Block(string genesisContent) : this(ComputeHash("", genesisContent), genesisContent)
        {
        }

        public Block(string prevHash, string content)
        {
            this.PreviousHash = prevHash;
            this.Content = content;
            this.Hash = ComputeHash(this.PreviousHash, this.Content);
        }

        private static string ComputeHash(string baseHash, string content)
        {
            byte[] bytes = Encoding.UTF8.GetBytes($"{content}{baseHash}{DateTime.Now:yyyyMMddHHmmss}");
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            return Convert.ToHexString(hash);
        }

        public bool Validate(string previousHash) =>
            ComputeHash(previousHash, this.Content) == this.Hash;

        public static bool Validate(Block block) =>
            block.Validate(block.PreviousHash);

        public override string ToString() =>
            $"ph:{this.PreviousHash},c:{this.Content},h:{this.Hash}";
    }
}
