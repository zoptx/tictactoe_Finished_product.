using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bijan_Bazaz_Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // collecter les nom des joueur ecrit pour les utiliser come donner dans le form1.
        private void button1_Click(object sender, EventArgs e)
        {
            TicTacToe.NomJoueur(Joueur1.Text, Joueur2.Text);
            this.Close();
        }
    }
}
