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
            buttonRules = new Button();
            buttonConfig = new Button();
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
            newGameBtn.Location = new Point(3, 3);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(297, 50);
            newGameBtn.TabIndex = 1;
            newGameBtn.Text = "Nouvelle partie";
            newGameBtn.UseVisualStyleBackColor = true;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // buttonRules
            // 
            buttonRules.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonRules.Location = new Point(306, 3);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new Size(297, 50);
            buttonRules.TabIndex = 2;
            buttonRules.Text = "Règles du jeu";
            buttonRules.UseVisualStyleBackColor = true;
            buttonRules.Click += buttonRulesClick;
            // 
            // buttonConfig
            // 
            buttonConfig.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonConfig.Location = new Point(609, 3);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.Size = new Size(298, 50);
            buttonConfig.TabIndex = 3;
            buttonConfig.Text = "Configurations";
            buttonConfig.UseVisualStyleBackColor = true;
            buttonConfig.Click += buttonConfigClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(buttonRules, 1, 0);
            tableLayoutPanel1.Controls.Add(newGameBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonConfig, 2, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Location = new Point(0, 214);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(910, 56);
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
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        public Label Titre;
        private Button newGameBtn;
        private Button buttonRules;
        private Button buttonConfig;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
