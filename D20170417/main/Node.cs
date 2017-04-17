using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20170417.main
{
    internal class Node
    {
        public Node Next { get; set; }
        public string Value { get; set; }

        internal Node(string value)
        {
            this.Value = value;
        }
    }
}
