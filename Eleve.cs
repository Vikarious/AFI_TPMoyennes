using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Eleve
    {
        // GET et SET les nom prenom des eleves ajouté a la Classe
        public string prenom
        {
            get;
            set;
        }
        public string nom
        {
            get;
            set;
        }
        // cree une liste de note d'un eleve
        public List <Note> note = new List <Note> ();

        // constructor pour la class Eleve
        public Eleve ( string firstName, string lastName )
        {
            prenom = firstName;
            nom = lastName;
        }

        // methode ajout d'une note à un eleve
        public void ajouterNote( Note noteEleve )
        {
            note.Add( noteEleve );
        }
        // methode calcule de la moyenne des notes d'un eleve dans une matiere
        public double Moyenne( int nomMatiere )
        {
            double total = 0;
            int comp = 0;

            foreach ( Note noteEleve in note ) {
                if ( noteEleve.matiere == nomMatiere ) {
                    total += noteEleve.note;
                    comp++;
                }
            }
            return Math.Round( total / comp, 2 );
        }

        // methode calcule de la moyenne general d'un eleve
        public double Moyenne()
        {
            double total = 0;
            int comp = 0;

            for (int i = 0; i < note[note.Count - 1].matiere; i++) {
                total += Moyenne(i);
                comp++;
            }
            return Math.Round( total / comp, 2 );
        }

    }
}