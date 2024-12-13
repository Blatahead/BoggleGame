namespace BoggleGameWinForm
{
    partial class Configurations
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
            label2 = new Label();
            label3 = new Label();
            comboBoxLangue = new ComboBox();
            isTrieText = new Label();
            button1 = new Button();
            label5 = new Label();
            comboBoxTaille = new ComboBox();
            saveConfigButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Young Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(324, 46);
            label1.Name = "label1";
            label1.Size = new Size(343, 67);
            label1.TabIndex = 0;
            label1.Text = "Configurations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Young Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(61, 242);
            label2.Name = "label2";
            label2.Size = new Size(212, 33);
            label2.TabIndex = 1;
            label2.Text = "Tri de dictionnaire :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Young Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(61, 170);
            label3.Name = "label3";
            label3.Size = new Size(99, 33);
            label3.TabIndex = 2;
            label3.Text = "Langue :";
            // 
            // comboBoxLangue
            // 
            comboBoxLangue.FormattingEnabled = true;
            comboBoxLangue.Items.AddRange(new object[] { "Anglais", "Français" });
            comboBoxLangue.Location = new Point(276, 181);
            comboBoxLangue.Name = "comboBoxLangue";
            comboBoxLangue.Size = new Size(121, 23);
            comboBoxLangue.TabIndex = 3;
            comboBoxLangue.Text = "Sélectionner";
            // 
            // isTrieText
            // 
            isTrieText.AutoSize = true;
            isTrieText.BackColor = Color.Transparent;
            isTrieText.Font = new Font("Young Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isTrieText.ForeColor = Color.Red;
            isTrieText.Location = new Point(276, 242);
            isTrieText.Name = "isTrieText";
            isTrieText.Size = new Size(98, 33);
            isTrieText.TabIndex = 4;
            isTrieText.Text = "Non trié";
            // 
            // button1
            // 
            button1.Location = new Point(400, 252);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Trier";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Young Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(61, 313);
            label5.Name = "label5";
            label5.Size = new Size(191, 33);
            label5.TabIndex = 6;
            label5.Text = "Taille du plateau :";
            label5.Click += label5_Click;
            // 
            // comboBoxTaille
            // 
            comboBoxTaille.FormattingEnabled = true;
            comboBoxTaille.Items.AddRange(new object[] { "4x4", "5x5", "6x6", "7x7", "8x8", "9x9", "10x10" });
            comboBoxTaille.Location = new Point(276, 324);
            comboBoxTaille.Name = "comboBoxTaille";
            comboBoxTaille.Size = new Size(121, 23);
            comboBoxTaille.TabIndex = 7;
            comboBoxTaille.Text = "Sélectionner";
            // 
            // saveConfigButton
            // 
            saveConfigButton.Font = new Font("Young Serif", 12F);
            saveConfigButton.Location = new Point(400, 414);
            saveConfigButton.Name = "saveConfigButton";
            saveConfigButton.Size = new Size(200, 50);
            saveConfigButton.TabIndex = 8;
            saveConfigButton.Text = "Sauvegarder";
            saveConfigButton.UseVisualStyleBackColor = true;
            saveConfigButton.Click += saveConfigButton_Click;
            // 
            // Configurations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(956, 520);
            Controls.Add(saveConfigButton);
            Controls.Add(comboBoxTaille);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(isTrieText);
            Controls.Add(comboBoxLangue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Configurations";
            Text = "Configurations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxLangue;
        private Label isTrieText;
        private Button button1;
        private Label label5;
        private ComboBox comboBoxTaille;
        private Button saveConfigButton;
    }
}