namespace BoggleGameWinForm
{
    partial class CreationJoueurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pseudo1title = new Label();
            pseudoJoueur1 = new TextBox();
            pseudo2title = new Label();
            pseudoJoueur2 = new TextBox();
            confirmCreationJoueurs = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Young Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 39);
            label1.Name = "label1";
            label1.Size = new Size(239, 33);
            label1.TabIndex = 0;
            label1.Text = "Création des joueurs";
            // 
            // pseudo1title
            // 
            pseudo1title.AutoSize = true;
            pseudo1title.Cursor = Cursors.SizeAll;
            pseudo1title.Location = new Point(160, 131);
            pseudo1title.Name = "pseudo1title";
            pseudo1title.Size = new Size(92, 15);
            pseudo1title.TabIndex = 1;
            pseudo1title.Text = "pseudo joueur 1";
            // 
            // pseudoJoueur1
            // 
            pseudoJoueur1.Location = new Point(152, 183);
            pseudoJoueur1.Name = "pseudoJoueur1";
            pseudoJoueur1.Size = new Size(100, 23);
            pseudoJoueur1.TabIndex = 2;
            // 
            // pseudo2title
            // 
            pseudo2title.AutoSize = true;
            pseudo2title.Location = new Point(471, 131);
            pseudo2title.Name = "pseudo2title";
            pseudo2title.Size = new Size(92, 15);
            pseudo2title.TabIndex = 3;
            pseudo2title.Text = "pseudo joueur 2";
            // 
            // pseudoJoueur2
            // 
            pseudoJoueur2.Location = new Point(463, 174);
            pseudoJoueur2.Name = "pseudoJoueur2";
            pseudoJoueur2.Size = new Size(100, 23);
            pseudoJoueur2.TabIndex = 4;
            // 
            // confirmCreationJoueurs
            // 
            confirmCreationJoueurs.Location = new Point(346, 254);
            confirmCreationJoueurs.Name = "confirmCreationJoueurs";
            confirmCreationJoueurs.Size = new Size(75, 23);
            confirmCreationJoueurs.TabIndex = 5;
            confirmCreationJoueurs.Text = "Confirmer";
            confirmCreationJoueurs.UseVisualStyleBackColor = true;
            confirmCreationJoueurs.Click += ConfirmationCreationJoueurs_Click;
            // 
            // CreationJoueurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(confirmCreationJoueurs);
            Controls.Add(pseudoJoueur2);
            Controls.Add(pseudo2title);
            Controls.Add(pseudoJoueur1);
            Controls.Add(pseudo1title);
            Controls.Add(label1);
            Name = "CreationJoueurs";
            Text = "CreationJoueur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label pseudo1title;
        private TextBox pseudoJoueur1;
        private Label pseudo2title;
        private TextBox pseudoJoueur2;
        private Button confirmCreationJoueurs;
    }
}