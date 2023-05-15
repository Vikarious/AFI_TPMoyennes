using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Matiere
    {

        public int rankMatiere = 0;

        // GET d'une chaine de character nom de la matiere
        public string nomMatiere 
        { 
            get; 
        }

        // constructor de la class Matiere
        public Matiere ( string nomMat )
        {
            nomMatiere = nomMat;
            rankMatiere++;
        }
        public override string? ToString() { return nomMatiere; }
    }
}