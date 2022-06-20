namespace Bijan_Bazaz_Tic_Tac_Toe
{
    partial class TicTacToe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(259, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(259, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetWinCountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newGameToolStripMenuItem.Text = "Nouveaux jeux";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetWinCountToolStripMenuItem
            // 
            this.resetWinCountToolStripMenuItem.Name = "resetWinCountToolStripMenuItem";
            this.resetWinCountToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.resetWinCountToolStripMenuItem.Text = "réinitialiser les points";
            this.resetWinCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Quitter";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Aide";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 27);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 2;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(93, 27);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 3;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(174, 27);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 4;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(12, 105);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(93, 105);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 6;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(174, 105);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 7;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(12, 186);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 8;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(93, 186);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(174, 186);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 10;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Location = new System.Drawing.Point(38, 303);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(13, 13);
            this.x_win_count.TabIndex = 12;
            this.x_win_count.Text = "0";
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Location = new System.Drawing.Point(119, 303);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(13, 13);
            this.draw_count.TabIndex = 12;
            this.draw_count.Text = "0";
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Location = new System.Drawing.Point(212, 303);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(13, 13);
            this.o_win_count.TabIndex = 12;
            this.o_win_count.Text = "0";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(96, 277);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(72, 13);
            this.lb2.TabIndex = 11;
            this.lb2.Text = "Draw count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label draw_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountToolStripMenuItem;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

