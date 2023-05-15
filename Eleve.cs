using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    public class Eleve
    {
        public string prenom 
        { 
            get; 
            private set;
        }
        public string nom 
        { 
            get; 
            private set;
        }
        public List<Note> notes 
        { 
            get; 
            private set; 
        }

        public Eleve(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.notes = new List<Note>();
        }

        public void ajouterNote(Note note)
        {
            this.notes.Add(note);
        }

        public float Moyenne(int matiere)
        {
            var notesMatiere = this.notes.Where(n => n.matiere == matiere).ToList();
            if (!notesMatiere.Any()) return 0;
            return (float)Math.Truncate(100 * notesMatiere.Average(n => n.note)) / 100;
        }

        public float Moyenne()
        {
            if (!this.notes.Any()) return 0;
            var moyennes = new List<float>();
            var matieres = this.notes.Select(n => n.matiere).Distinct();
            foreach (var matiere in matieres)
            {
                moyennes.Add(Moyenne(matiere));
            }
            return (float)Math.Truncate(100 * moyennes.Average()) / 100;
        }
    }
}
