using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samesem_Dictionary
{
    class Dictionnaire
    {
        String pathFichier;
        Arbre arbre;

        public Dictionnaire() { }
        public Dictionnaire(String pathFichier)
        {
            this.pathFichier=pathFichier;
            Arbre arbre = new Arbre();
        }

        public Arbre getArbre()
        {
            return arbre;
        }

        public void loadDictionnaire()
        {
            String[] ligne = System.IO.File.ReadAllLines(pathFichier);
            for(int i=0;i<ligne.Length;i++)
            {
                String[] ligneSepare = ligne[i].Split(';');
                arbre = Arbre.inserer(arbre, ligneSepare[0],ligneSepare[1]);
            }

        }
      }
}

