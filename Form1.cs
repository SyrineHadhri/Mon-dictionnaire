using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samesem_Dictionary
{
    public partial class Form1 : Form
    {
        String motRechercher;
        Dictionnaire dictionnaire;

        public Form1()
        {
            InitializeComponent();
            dictionnaire = new Dictionnaire(@"D:\syrine\ENIS\C sharp\Samesem Dictionary\Samesem Dictionary\baseDictionary.txt");
            dictionnaire.loadDictionnaire();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.txtDefinition.Clear();
           String motSelectionne = this.listBoxMots.SelectedItem.ToString();
           Arbre arbreDeMotSelectionne=Arbre.rechercherDefinition(motSelectionne, dictionnaire.getArbre());
           this.txtDefinition.AppendText(arbreDeMotSelectionne.definition);
        }

        private void txtMot_TextChanged(object sender, EventArgs e)
        {
            bool test = true;
            this.listBoxMots.Items.Clear();

            for (int i = 0; i < this.txtMot.Text.Length; i++)
                if ((this.txtMot.Text[i] < 'A') || (this.txtMot.Text[i] > 'z'))
                {
                    test = false;
                    break;
                }

            if (test)
            {
                this.txtDefinition.Clear();
                motRechercher = this.txtMot.Text.ToLower();
                labErreur.Visible = false;
                picErreur.Visible = false;

                if (String.Compare(motRechercher, "") != 0)
                {  
                   List<String> myList = new List<String>();
                   Arbre.rechercherMots(motRechercher, dictionnaire.getArbre(), myList);
                   //myList.Sort();
                   listBoxMots.Items.AddRange(myList.ToArray());
                }
                
            }

            else
               {
                    labErreur.Visible = true;
                    picErreur.Visible = true;
                }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        
        }

        private void txtDefinition_TextChanged(object sender, EventArgs e)
        {
        }


    }
}
