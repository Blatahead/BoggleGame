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
            comboBox1 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Young Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(300, 51);
            label1.Name = "label1";
            label1.Size = new Size(343, 67);
            label1.TabIndex = 0;
            label1.Text = "Configurations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Young Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 201);
            label2.Name = "label2";
            label2.Size = new Size(212, 33);
            label2.TabIndex = 1;
            label2.Text = "Tri de dictionnaire :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Young Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 148);
            label3.Name = "label3";
            label3.Size = new Size(99, 33);
            label3.TabIndex = 2;
            label3.Text = "Langue :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Français", "Anglais" });
            comboBox1.Location = new Point(276, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Young Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(276, 201);
            label4.Name = "label4";
            label4.Size = new Size(98, 33);
            label4.TabIndex = 4;
            label4.Text = "Non trié";
            // 
            // button1
            // 
            button1.Location = new Point(400, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Trier";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Young Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(61, 257);
            label5.Name = "label5";
            label5.Size = new Size(191, 33);
            label5.TabIndex = 6;
            label5.Text = "Taille du plateau :";
            label5.Click += label5_Click;
            // 
            // Configurations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(956, 520);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}