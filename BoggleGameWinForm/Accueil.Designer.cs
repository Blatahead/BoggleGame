﻿namespace BoggleGame
{
    partial class Accueil
    {
        /// <summary>
        ///  Variable designer requise (par défault dans le code)
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

        #region Designer Forms Accueil  

        /// <summary>
        ///  Méthode qui s'éxécute au lancement du program avec toutes les 
        ///  propritétés et méthodes lors du loading
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Titre = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            newGameBtn = new Button();
            buttonRules = new Button();;
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Titre
            // 
            Titre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Titre.BackColor = Color.Transparent;
            Titre.Font = new Font("Young Serif", 70F, FontStyle.Bold);
            Titre.ForeColor = SystemColors.ButtonHighlight;
            Titre.Location = new Point(0, 0);
            Titre.Margin = new Padding(0);
            Titre.Name = "Titre";
            Titre.Size = new Size(910, 211);
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
            newGameBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            newGameBtn.Font = new Font("Segoe UI", 15F);
            newGameBtn.Location = new Point(10, 79);
            newGameBtn.Margin = new Padding(10);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(283, 70);
            newGameBtn.TabIndex = 1;
            newGameBtn.Text = "Nouvelle partie";
            newGameBtn.UseVisualStyleBackColor = true;
            newGameBtn.Click += ButtonGameClick;
            // 
            // buttonRules
            // 
            buttonRules.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonRules.Font = new Font("Segoe UI", 15F);
            buttonRules.Location = new Point(313, 79);
            buttonRules.Margin = new Padding(10);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new Size(283, 70);
            buttonRules.TabIndex = 2;
            buttonRules.Text = "Règles du jeu";
            buttonRules.UseVisualStyleBackColor = true;
            buttonRules.Click += buttonRulesClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(buttonRules, 1, 0);
            tableLayoutPanel1.Controls.Add(newGameBtn, 0, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Location = new Point(0, 263);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(912, 228);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(908, 491);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Titre);
            Name = "Accueil";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Chargement_Accueil;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        public Label Titre;
        private Button newGameBtn;
        private Button buttonRules;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
