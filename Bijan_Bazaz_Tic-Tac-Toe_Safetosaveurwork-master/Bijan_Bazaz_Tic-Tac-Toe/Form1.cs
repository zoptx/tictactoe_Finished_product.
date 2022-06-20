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
    public partial class TicTacToe : Form
    {
        bool tour = true; // true = le tour au jouer x; false = le tour au jouer y
        int nombre_tour = 0;
        static string Joueur1, Joueur2;
        public TicTacToe()
        {
            InitializeComponent();
        }
        public static void NomJoueur(string n1, String n2)
        {
            Joueur1 = n1;
            Joueur2 = n2;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Par Bijan", "Tic Tac Toe About");
        }

        // pour sotir de laplication
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //verifie qui a clicquer et compte le nombre de tour
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (tour)
                b.Text = "X";
            else
                b.Text = "0";

            tour = !tour;
            b.Enabled = false;
            nombre_tour++;

            ChercherPourGagnant();
        }
        // verifie pour le gangnant
        private void ChercherPourGagnant()
        {
            bool there_is_a_winner = false;

            // verifie horizontal 
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //verifie Vertical 
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //verifie diagonale
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            // message aux gangnant pour lui viliciter et afficher les point aux jouer corespondent.
            if (there_is_a_winner)
            {
                désactiverBoutons();

                String winner = "";
                if (tour)
                {
                    winner = Joueur2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = Joueur1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Gangner! ", " Youpi!");
            }//Fin de if

            //ceci arrete le jeux si le jeux a put de posibiliter et personne a gangner
            else
            {
                if (nombre_tour == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show(" dessiner ", ":( ");
                }
            }
        }//End checkForWinner

        //désactiver les boutton
        private void désactiverBoutons()
        {
            try
            {
                foreach (Control C in this.Controls)
                {
                    Button b = (Button)C;
                    b.Enabled = false;
                }//End foreach
            }//End try
            catch { }
        }// Fin de désactivation des boutton

        // Recomencer le jeux a nouveaux, toute reset.
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tour = true;
            nombre_tour = 0;


            foreach (Control C in this.Controls)
            {
                try
                {
                    Button b = (Button)C;
                    b.Enabled = true;
                    b.Text = "";
                }//End try
                catch { }
            }//End foreach

        }//Fin de nouveaux jeux
        //Indique ses le tour a qui de jouer, jouer X ou O
        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (tour)
                    b.Text = "X ";
                else
                    b.Text = "O ";
            }//End if
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        } // Fin de indication de jouer 

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }
        // ouvre un form pour choissir le nom des joueurs 
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            Form F2 = new Form2();
            F2.ShowDialog();
            label1.Text = Joueur1;
            label2.Text = Joueur2;
        }
    }
}

