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
    public partial class ordinateur : Form
    {
        // ci-dessous la classe du joueur qui a deux valeurs
        // X et O
        // En faisant cela, nous pouvons contrôler les symboles du joueur et de l'IA.
        public enum player
        {
            X, O
        }

       player currentPlayer; // appel de la classe du joueur 

        List<Button> buttons; // création d'une LISTE ou d'un tableau de boutons
        Random rand = new Random(); // importation de la classe du générateur de nombres aléatoires
        int playerWins = 0; // mettre l'entier de victoire du joueur à 0
        int computerWins = 0; // mettre l'entier de victoire de l'ordinateur à 0

        public ordinateur()
        {
            InitializeComponent();
            resetGame(); 
        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; // trouver quel bouton a été cliqué
            currentPlayer = player.X; // mettre le joueur à X
            button.Text = currentPlayer.ToString(); // changer le texte du bouton a joueur X
            button.Enabled = false; // désactiver le bouton
            button.BackColor = System.Drawing.Color.Cyan; // changer la couleur du joueur en Cyan
            buttons.Remove(button); //supprimer le bouton de la liste des boutons pour que l'IA ne puisse pas non plus le cliquer
            Check(); // vérifier si le joueur a gagné
            AImoves.Start(); //  démarrer le timerAI
        }

        private void AImove(object sender, EventArgs e)
        {
            //Le CPU choisira aléatoirement un bouton à cliquer dans la liste. 
            // Si le tableau est supérieur à 0, le processeur continuera à jouer.
            // Si le tableau est inférieur à 0, le jeu s'arrête.
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); // générer un numéro aléatoire parmi le nombre de boutons disponibles
                buttons[index].Enabled = false; // attribuer le numéro au bouton
                                                // quand le numéro aléatoire est généré, nous regardons dans la liste.
                                                // pour savoir quel est ce numéro, nous sélectionnons ce bouton
                                                // par exemple, si le nombre est 8
                                                // nous sélectionnons ensuite le 8ème bouton de la liste

                currentPlayer = player.O; // régler l'IA avec O
                buttons[index].Text = currentPlayer.ToString(); // afficher O sur le bouton
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon; // changez l'arrière-plan du bouton en dark salmon colour
                buttons.RemoveAt(index); // supprimer ce bouton de la liste
                Check(); // vérifier si l'IA a gagné quelque chose
                AImoves.Stop(); // arrête le timerAI
            }
        }

        private void restartGame(object sender, EventArgs e)
        {
            // Cette fonction est liée au bouton de réinitialisation.
            // lorsque le bouton de réinitialisation est cliqué, alors
            // cette fonction exécutera la fonction de réinitialisation du jeu.
            resetGame();
        }

        private void loadbuttons()
        {
            // ceci est la fonction personnalisée qui chargera tous les boutons du formulaire dans la liste des boutons.
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button9, button8 };
        }

        private void resetGame()
        {
            //Vérifier chacun des boutons avec une étiquette de jeu.
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; // changez-les tous en activés ou cliquables
                    ((Button)X).Text = "?"; // mettre le texte en point d'interrogation
                    ((Button)X).BackColor = default(Color); // changez la couleur de fond pour les couleurs par défaut des boutons
                }
            }

            loadbuttons(); // Exécutez la fonction de chargement des boutons pour que tous les boutons soient réinsérés dans le tableau.
        }

        private void Check()
        {
            //Dans cette fonction, nous allons vérifier si le joueur ou l'IA a gagné.
            // Nous avons deux très grandes déclarations if avec les possibilités de victoire.
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                // si l'une des conditions précédentes est réalisée
                AImoves.Stop(); //arrêtez la minuterie
                MessageBox.Show("Joueur gagner"); // montrer un message au joueur
                playerWins++; // augmenter les point du joueur 
                label1.Text = "Joueur gagner- " + playerWins; // mise à jour de l'étiquette du joueur
                resetGame(); // exécuter la fonction de réinitialisation du jeu
            }
            // l'instruction if ci-dessous est destinée au cas où l'IA gagne la partie.
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {

                // si l'une des conditions précédentes est réalisée, nous ferons ce qui suit
                // ce code sera exécuté lorsque l'IA gagnera la partie.
                AImoves.Stop();// arrête le minuteur
                MessageBox.Show("Ordi Gagner");  // afficher une boîte de message pour dire que l'ordinateur a gagné
                computerWins++; // augmenter le nombre de points gagnés par l'ordinateur
                label2.Text = "Ordi Gagner- " + computerWins; // mettre à jour l'étiquette  pour lordinateurs gagnants
                resetGame(); // réinitialiser
            }
        }

    }
}
