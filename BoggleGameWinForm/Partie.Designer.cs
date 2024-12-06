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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            TimerPartieTitle = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(PlateauPartie, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.9230766F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.07692F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.Size = new Size(1124, 590);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1118, 127);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(TimerPartieTitle, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(553, 121);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // TimerPartieTitle
            // 
            TimerPartieTitle.AutoSize = true;
            TimerPartieTitle.Dock = DockStyle.Fill;
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
            label1.Location = new Point(3, 60);
            label1.Name = "label1";
            label1.Size = new Size(547, 61);
            label1.TabIndex = 1;
            label1.Text = "Temps du joueur restant :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            //textBox1.Location = new Point(3, 497);
            textBox1.MaximumSize = new Size(200, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Rentrez vos mots";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Partie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 590);
            Controls.Add(tableLayoutPanel1);
            Name = "Partie";
            Text = "Partie";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel PlateauPartie;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label TimerPartieTitle;
        private Label label1;
        private TextBox textBox1;
    }
}