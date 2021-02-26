using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralizare_absente
{
    class AbsentaCollection
    {
        List<Absenta> absente;

        public AbsentaCollection()
        {
            absente = new List<Absenta>();
        }

        public List<Absenta> Absente { get => absente; set => absente = value; }

        public bool isEmpty()
        {
            if (absente.Count > 0)
                return false;
            return true;
        }

        public override string ToString()
        {
            string stringAbsente = "";

            foreach (Absenta abs in absente)
                stringAbsente += abs + "\n";

            return stringAbsente;
        }

    }
}
