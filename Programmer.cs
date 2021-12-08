using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1pr31s9
{
    internal class Programmer
    {
        public string Name { get; set; }
        public int Program { get; set; }
        public int Language { get; set; }
        public Programmer(string N, int Prog, int L)
        {
            Name = N;
            Program = Prog;
            Language = L;
        }
        public int schetQ()
        {
            int Q = Program * Language;
            return Q;
        }
    }
}
