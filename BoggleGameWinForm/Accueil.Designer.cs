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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Titre
            // 
            Titre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Titre.BackColor = Color.Transparent;
            Titre.Font = new Font("Young Serif", 50F, FontStyle.Bold);
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
            newGameBtn.Location = new Point(3, 118);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(301, 41);
            newGameBtn.TabIndex = 1;
            newGameBtn.Text = "Nouvelle partie";
            newGameBtn.UseVisualStyleBackColor = true;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(310, 118);
            button2.Name = "button2";
            button2.Size = new Size(301, 41);
            button2.TabIndex = 2;
            button2.Text = "Règles du jeu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.DialogResult = DialogResult.Cancel;
            button3.Location = new Point(617, 118);
            button3.Name = "button3";
            button3.Size = new Size(290, 41);
            button3.TabIndex = 3;
            button3.Text = "Configurations";
            button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 295F));
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 1, 0);
            tableLayoutPanel1.Controls.Add(newGameBtn, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 214);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(910, 277);
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
            Load += chargement_Accueil;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        public Label Titre;
        private Button newGameBtn;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
