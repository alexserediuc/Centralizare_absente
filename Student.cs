using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Centralizare_absente
{
    class Student
    {
       
        string nume;
        string prenume;
        string facultate;
        string cnp;
        AbsentaCollection absente;

        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Facultate { get => facultate; set => facultate = value; }
        public string Cnp { get => cnp; set => cnp = value; }
        public AbsentaCollection Absente { get => absente; set => absente = value; }


        //identificatorul este reprezentat de ultimele 4 cifre din cnp
        public string getIdentificator()
        {
            return cnp.Substring(cnp.Length - 4);
        }

        public override string ToString()
        {
           
            return Nume + " " + Prenume + " " + Facultate + " " + Cnp + " " + absente;
        }
    }
}
