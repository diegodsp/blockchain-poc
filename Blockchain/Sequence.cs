using System;
using System.Collections.Generic;
using System.Linq;

namespace Blockchain
{
    public class Sequence : List<Block>
    {
        public Sequence(string genesisContent) : base() =>
            base.Add(new Block(genesisContent));

        public void Add(string content) =>
            base.Add(new Block(this.Last().Hash, content));

        public void Validate()
        {
            for (int i = 1; i < this.Count; i++)
                if (!this[i].Validate(this[i - 1].Hash))
                    throw new Exception($"Sequência inválida no índice #{i}");
        }
    }
}
