using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
     class Block
    {
        public int id {  get; private set; }
        public string Data { get; private set; }
        public DateTime Created { get; private set; }
        public string Hash {get; private set; }
        public string PreviousHash { get; private set; }
        public string User { get; set; }
        
        
        public Block()
        {
            id = 1;
            Data = "Hash";
            Created = DateTime.Parse("24.04.2024 00:00:00.000").ToLocalTime();
            PreviousHash = "11111";
            User = "Dmitriy";
        }
        public Block(string data,string user ,Block block)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException($"Empty data", nameof(data));
            }

            if (block == null)
            {
                throw new ArgumentNullException("Empty Argument Block", nameof(block));
            }

            if(string.IsNullOrEmpty(user))
            {
                throw new ArgumentNullException("Empty argument user", nameof(user));
            }
            Data = data;
            User = user;
            PreviousHash = block.Hash;
            Created = DateTime.UtcNow;
            id = block.id + 1;

        }
    }
}
