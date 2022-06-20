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
    // ceci a ete fait pour que le joueur puisse avoir le choix sur le mode quil veux jouer, soit contre un ordi ou 1vs1.
    public partial class Mode_de_jeux : Form
    {
        public Mode_de_jeux()
        {
            InitializeComponent();
        }
        // ouvre le form TicTacToe 
        private void button1_Click(object sender, EventArgs e)
        {
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Show();
            this.Hide();
        }
        // ouvre le from ordinateur
        private void button2_Click(object sender, EventArgs e)
        {
            ordinateur ordinateur = new ordinateur();
            ordinateur.Show();
            this.Hide();
        }
    }
}
