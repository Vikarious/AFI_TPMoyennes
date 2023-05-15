using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    public class Classe
    {
        public string nomClasse 
        { 
            get; 
            private set;
        }
        public List<string> matieres 
        { 
            get; 
            private set; 
        }
        public List<Eleve> eleves 
        { get; 
            private set; 
        }

        public Classe(string nomClasse)
        {
            this.nomClasse = nomClasse;
            this.matieres = new List<string>();
            this.eleves = new List<Eleve>();
        }

        public void ajouterEleve(string prenom, string nom)
        {
            this.eleves.Add(new Eleve(prenom, nom));
        }

        public void ajouterMatiere(string matiere)
        {
            this.matieres.Add(matiere);
        }

        public float Moyenne(int matiere)
        {
            var moyennesEleves = this.eleves.Select(e => e.Moyenne(matiere)).ToList();
            if (!moyennesEleves.Any()) return 0;
            return (float)Math.Truncate(100 * moyennesEleves.Average()) / 100;
        }

        public float Moyenne()
        {
            var moyennesMatieres = new List<float>();
            for (int i = 0; i < this.matieres.Count; i++)
            {
                moyennesMatieres.Add(Moyenne(i));
            }
            return (float)Math.Truncate(100 * moyennesMatieres.Average()) / 100;
        }
    }
}
