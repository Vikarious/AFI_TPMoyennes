using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Classe
    {
        // recuperera le nom de la Classe ( 6eme A)
        public string nomClasse;

        // GET recuperation listes d'eleve et matiere
        public List <Eleve> eleves 
        {
            get;
        }
        public List <Matiere> matieres 
        { 
            get;  
        }

        // constructor pour la class Classe
        public Classe ( string refClasse )
        {
            nomClasse = refClasse;
            matieres = new List <Matiere>();
            eleves = new List <Eleve>();
        }

        // methode ajout d'eleve dans une liste de max 30 sinon affichage
        public void ajouterEleve ( string prenom, string nom )
        {
            if (eleves.Count < 30) {
                eleves.Add( new Eleve ( prenom, nom ) );
            }

            else {
                Console.Write( "ERREUR: il y'a trop d'eleve dans la classe." );
            }

        }

        // methode calcule moyenne general arrondie de la Classe 
        public double Moyenne()
        {
            double tot = 0;
            int comp = 0;

            for ( int matiere = 0; matiere < matieres.Count; matiere++ ) {
                tot += Moyenne( matiere );
                comp ++;
            }
            return Math.Round( tot / comp, 2 );
        }

        // methode calcule moyenne de la Classe d'une matiere d'un certain rang de la liste matiere 
        public double Moyenne( int rankMatiere )
        {
            double tot1 = 0;
            int comp = 0;

            foreach ( Eleve eleve in eleves ) {
                tot1 += eleve.Moyenne( rankMatiere );
                comp ++;
            }
            return Math.Round( tot1 / comp, 2 );
        }

        // methode ajout d'une matiere a une liste de 10 sinon affichage
        public void ajouterMatiere ( string nomMatiere )
        {
            if ( matieres.Count < 10 ) {
                matieres.Add( new Matiere(nomMatiere));
            }
            else {
                Console.Write( "ERREUR: la classe de cours ne peut pas exceder + de 10 matieres." );
            }
        }
    }
}