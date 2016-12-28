using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samesem_Dictionary
{
    public class Arbre
    {
        public String mot;
        public String definition;
        public Arbre filsGauche;
        public Arbre filsDroite;

        public Arbre() { }

        public Arbre(String mot, String definition)
        {
            this.mot = mot;
            this.definition = definition;
        }

        
        public static Arbre inserer(Arbre arbre,String mot,String definition)
        {
            if (arbre == null)
                return new Arbre(mot, definition);

            else
            {
                if (String.Compare(arbre.mot, mot)> 0)
                    arbre.filsGauche=inserer(arbre.filsGauche, mot, definition);
                
                else if (String.Compare(arbre.mot, mot)<0)
                    arbre.filsDroite=inserer(arbre.filsDroite, mot, definition);
                return arbre;
            }
        }

        public static List<String> rechercherMots(String mot,Arbre arbre,List<String> myList)
        {
             if (arbre != null)
             {
                 
                 rechercherMots(mot, arbre.filsGauche, myList);
                 if ((arbre.mot).StartsWith(mot))
                                      myList.Add(arbre.mot);

                 rechercherMots(mot,arbre.filsDroite,myList);
             }
             return myList;
        }


       public static Arbre rechercherDefinition(String mot, Arbre arbre)
        {
            while ((arbre != null) && (String.Compare(mot,arbre.mot) != 0))
            { 
                if (String.Compare(mot,arbre.mot) < 0)
                    arbre = arbre.filsGauche;

                else
                    arbre = arbre.filsDroite;
            }
            return arbre;
        }
        
    }
}
