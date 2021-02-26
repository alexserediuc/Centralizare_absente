using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralizare_absente
{
    class Absenta
    {
        DateTime data;
        string activitate;

        public DateTime Data { get => data; set => data = value; }
        public string Activitate { get => activitate; set => activitate = value; }

        public override String ToString()
        {
            return Activitate + " " + Data;
        }
    }
}
