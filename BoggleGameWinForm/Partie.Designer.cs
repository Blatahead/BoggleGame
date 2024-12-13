namespace BoggleGameWinForm
{
    partial class Partie
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
            PlateauPartie = new TableLayoutPanel();
            tableLayoutGeneral = new TableLayoutPanel();
            tableLayoutTopChronos = new TableLayoutPanel();
            tableLayoutTextChronos = new TableLayoutPanel();
            TimerPartieTitle = new Label();
            label1 = new Label();
            tableLayoutChronos = new TableLayoutPanel();
            chronoPartie = new Label();
            chronoJoueur = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            inputBoxMots = new TextBox();
            peudoJoueur = new Label();
            tableLayoutGeneral.SuspendLayout();
            tableLayoutTopChronos.SuspendLayout();
            tableLayoutTextChronos.SuspendLayout();
            tableLayoutChronos.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PlateauPartie
            // 
            PlateauPartie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlateauPartie.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PlateauPartie.Location = new Point(3, 136);
            PlateauPartie.Name = "PlateauPartie";
            PlateauPartie.Size = new Size(1118, 355);
            PlateauPartie.TabIndex = 0;
            // 
            // tableLayoutGeneral
            // 
            tableLayoutGeneral.AutoSize = true;
            tableLayoutGeneral.ColumnCount = 1;
            tableLayoutGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutGeneral.Controls.Add(PlateauPartie, 0, 1);
            tableLayoutGeneral.Controls.Add(tableLayoutTopChronos, 0, 0);
            tableLayoutGeneral.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutGeneral.Dock = DockStyle.Fill;
            tableLayoutGeneral.Location = new Point(0, 0);
            tableLayoutGeneral.Name = "tableLayoutGeneral";
            tableLayoutGeneral.RowCount = 3;
            tableLayoutGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 26.9230766F));
            tableLayoutGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 73.07692F));
            tableLayoutGeneral.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutGeneral.Size = new Size(1124, 590);
            tableLayoutGeneral.TabIndex = 2;
            // 
            // tableLayoutTopChronos
            // 
            tableLayoutTopChronos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutTopChronos.ColumnCount = 2;
            tableLayoutTopChronos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutTopChronos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutTopChronos.Controls.Add(tableLayoutTextChronos, 0, 0);
            tableLayoutTopChronos.Controls.Add(tableLayoutChronos, 1, 0);
            tableLayoutTopChronos.Location = new Point(3, 3);
            tableLayoutTopChronos.Name = "tableLayoutTopChronos";
            tableLayoutTopChronos.RowCount = 1;
            tableLayoutTopChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutTopChronos.Size = new Size(1118, 127);
            tableLayoutTopChronos.TabIndex = 1;
            // 
            // tableLayoutTextChronos
            // 
            tableLayoutTextChronos.ColumnCount = 1;
            tableLayoutTextChronos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutTextChronos.Controls.Add(TimerPartieTitle, 0, 0);
            tableLayoutTextChronos.Controls.Add(label1, 0, 1);
            tableLayoutTextChronos.Dock = DockStyle.Fill;
            tableLayoutTextChronos.Location = new Point(3, 3);
            tableLayoutTextChronos.Name = "tableLayoutTextChronos";
            tableLayoutTextChronos.RowCount = 2;
            tableLayoutTextChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutTextChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutTextChronos.Size = new Size(553, 121);
            tableLayoutTextChronos.TabIndex = 0;
            // 
            // TimerPartieTitle
            // 
            TimerPartieTitle.AutoSize = true;
            TimerPartieTitle.Dock = DockStyle.Fill;
            TimerPartieTitle.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerPartieTitle.Location = new Point(3, 0);
            TimerPartieTitle.Name = "TimerPartieTitle";
            TimerPartieTitle.Size = new Size(547, 60);
            TimerPartieTitle.TabIndex = 0;
            TimerPartieTitle.Text = "Temps de partie restant :";
            TimerPartieTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 60);
            label1.Name = "label1";
            label1.Size = new Size(547, 61);
            label1.TabIndex = 1;
            label1.Text = "Temps du joueur restant :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutChronos
            // 
            tableLayoutChronos.ColumnCount = 1;
            tableLayoutChronos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutChronos.Controls.Add(chronoPartie, 0, 0);
            tableLayoutChronos.Controls.Add(chronoJoueur, 0, 1);
            tableLayoutChronos.Dock = DockStyle.Fill;
            tableLayoutChronos.Location = new Point(562, 3);
            tableLayoutChronos.Name = "tableLayoutChronos";
            tableLayoutChronos.RowCount = 2;
            tableLayoutChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutChronos.Size = new Size(553, 121);
            tableLayoutChronos.TabIndex = 1;
            // 
            // chronoPartie
            // 
            chronoPartie.AutoSize = true;
            chronoPartie.Dock = DockStyle.Fill;
            chronoPartie.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chronoPartie.Location = new Point(3, 0);
            chronoPartie.Name = "chronoPartie";
            chronoPartie.Size = new Size(547, 60);
            chronoPartie.TabIndex = 0;
            chronoPartie.Text = "label2";
            chronoPartie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chronoJoueur
            // 
            chronoJoueur.AutoSize = true;
            chronoJoueur.Dock = DockStyle.Fill;
            chronoJoueur.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chronoJoueur.Location = new Point(3, 60);
            chronoJoueur.Name = "chronoJoueur";
            chronoJoueur.Size = new Size(547, 61);
            chronoJoueur.TabIndex = 1;
            chronoJoueur.Text = "label3";
            chronoJoueur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(inputBoxMots, 0, 1);
            tableLayoutPanel1.Controls.Add(peudoJoueur, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 497);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1118, 90);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // inputBoxMots
            // 
            inputBoxMots.Anchor = AnchorStyles.None;
            inputBoxMots.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputBoxMots.Location = new Point(309, 54);
            inputBoxMots.MaximumSize = new Size(500, 40);
            inputBoxMots.MinimumSize = new Size(500, 20);
            inputBoxMots.Name = "inputBoxMots";
            inputBoxMots.Size = new Size(500, 26);
            inputBoxMots.TabIndex = 2;
            inputBoxMots.Text = "Rentrez vos mots";
            inputBoxMots.TextAlign = HorizontalAlignment.Center;
            inputBoxMots.KeyDown += inputBoxMots_KeyDown;
            // 
            // peudoJoueur
            // 
            peudoJoueur.Anchor = AnchorStyles.None;
            peudoJoueur.AutoSize = true;
            peudoJoueur.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            peudoJoueur.Location = new Point(526, 11);
            peudoJoueur.Name = "peudoJoueur";
            peudoJoueur.Size = new Size(65, 22);
            peudoJoueur.TabIndex = 3;
            peudoJoueur.Text = "label2";
            // 
            // Partie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 590);
            Controls.Add(tableLayoutGeneral);
            Name = "Partie";
            Text = "Partie";
            WindowState = FormWindowState.Maximized;
            tableLayoutGeneral.ResumeLayout(false);
            tableLayoutTopChronos.ResumeLayout(false);
            tableLayoutTextChronos.ResumeLayout(false);
            tableLayoutTextChronos.PerformLayout();
            tableLayoutChronos.ResumeLayout(false);
            tableLayoutChronos.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel PlateauPartie;
        private TableLayoutPanel tableLayoutGeneral;
        private TableLayoutPanel tableLayoutTopChronos;
        private TableLayoutPanel tableLayoutTextChronos;
        private Label TimerPartieTitle;
        private Label label1;
        private TextBox inputBoxMots;
        private TableLayoutPanel tableLayoutChronos;
        private TableLayoutPanel tableLayoutPanel1;
        private Label peudoJoueur;
        private Label chronoPartie;
        private Label chronoJoueur;
    }
}