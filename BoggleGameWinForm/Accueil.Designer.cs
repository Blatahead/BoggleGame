namespace BoggleGame
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Titre = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            newGameBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Titre
            // 
            Titre.BackColor = Color.Transparent;
            Titre.Font = new Font("Young Serif", 30F, FontStyle.Bold);
            Titre.ForeColor = SystemColors.ButtonHighlight;
            Titre.Location = new Point(0, 84);
            Titre.Margin = new Padding(0);
            Titre.Name = "Titre";
            Titre.Size = new Size(800, 92);
            Titre.TabIndex = 0;
            Titre.Text = "BoggleGame";
            Titre.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // newGameBtn
            // 
            newGameBtn.Location = new Point(139, 267);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(116, 41);
            newGameBtn.TabIndex = 1;
            newGameBtn.Text = "Nouvelle partie";
            newGameBtn.UseVisualStyleBackColor = true;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(331, 267);
            button2.Name = "button2";
            button2.Size = new Size(114, 41);
            button2.TabIndex = 2;
            button2.Text = "Règles du jeu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(517, 267);
            button3.Name = "button3";
            button3.Size = new Size(114, 41);
            button3.TabIndex = 3;
            button3.Text = "Configurations";
            button3.UseVisualStyleBackColor = true;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(newGameBtn);
            Controls.Add(Titre);
            Name = "Accueil";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        public Label Titre;
        private Button newGameBtn;
        private Button button2;
        private Button button3;
    }
}
