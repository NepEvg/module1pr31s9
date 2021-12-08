using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1pr31s9
{
    internal class Nasled:Programmer
    {
        int ProgN;
        int LanguageN;

        public Nasled(string Name, int ProgN, int LanguageN) :base( Name, ProgN, LanguageN)
        {
            this.ProgN = ProgN;
        }
        public int chetQp(int Q)
        {
            int Qp = Q / ProgN;
            return Qp;
        }
    }
}
