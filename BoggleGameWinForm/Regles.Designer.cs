namespace BoggleGameWinForm
{
    partial class Regles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regles));
            detailsRegles = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // detailsRegles
            // 
            detailsRegles.AllowDrop = true;
            detailsRegles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            detailsRegles.Font = new Font("Segoe UI", 15F);
            detailsRegles.Location = new Point(0, 0);
            detailsRegles.Margin = new Padding(0);
            detailsRegles.Name = "detailsRegles";
            detailsRegles.Size = new Size(913, 510);
            detailsRegles.TabIndex = 0;
            detailsRegles.Text = resources.GetString("detailsRegles.Text");
            detailsRegles.TextAlign = ContentAlignment.MiddleLeft;
            detailsRegles.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Young Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(318, 47);
            label2.Name = "label2";
            label2.Size = new Size(299, 67);
            label2.TabIndex = 1;
            label2.Text = "Règles du jeu";
            // 
            // Regles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(913, 510);
            Controls.Add(label2);
            Controls.Add(detailsRegles);
            Name = "Regles";
            Text = "Regles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label detailsRegles;
        private Label label2;
    }
}