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
            inputBoxMots = new TextBox();
            tableLayoutGeneral.SuspendLayout();
            tableLayoutTopChronos.SuspendLayout();
            tableLayoutTextChronos.SuspendLayout();
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
            PlateauPartie.Paint += PlateauPartie_Paint;
            // 
            // tableLayoutGeneral
            // 
            tableLayoutGeneral.AutoSize = true;
            tableLayoutGeneral.ColumnCount = 1;
            tableLayoutGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutGeneral.Controls.Add(PlateauPartie, 0, 1);
            tableLayoutGeneral.Controls.Add(tableLayoutTopChronos, 0, 0);
            tableLayoutGeneral.Controls.Add(inputBoxMots, 0, 2);
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
            tableLayoutChronos.Dock = DockStyle.Fill;
            tableLayoutChronos.Location = new Point(562, 3);
            tableLayoutChronos.Name = "tableLayoutChronos";
            tableLayoutChronos.RowCount = 2;
            tableLayoutChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutChronos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutChronos.Size = new Size(553, 121);
            tableLayoutChronos.TabIndex = 1;
            // 
            // inputBoxMots
            // 
            inputBoxMots.Anchor = AnchorStyles.None;
            inputBoxMots.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputBoxMots.Location = new Point(312, 529);
            inputBoxMots.MaximumSize = new Size(500, 40);
            inputBoxMots.MinimumSize = new Size(500, 20);
            inputBoxMots.Name = "inputBoxMots";
            inputBoxMots.Size = new Size(500, 26);
            inputBoxMots.TabIndex = 2;
            inputBoxMots.Text = "Rentrez vos mots";
            inputBoxMots.TextAlign = HorizontalAlignment.Center;
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
            Load += Partie_Load;
            tableLayoutGeneral.ResumeLayout(false);
            tableLayoutGeneral.PerformLayout();
            tableLayoutTopChronos.ResumeLayout(false);
            tableLayoutTextChronos.ResumeLayout(false);
            tableLayoutTextChronos.PerformLayout();
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
    }
}