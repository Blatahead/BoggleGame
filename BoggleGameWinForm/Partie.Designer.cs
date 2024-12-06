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
            SuspendLayout();
            // 
            // PlateauPartie
            // 
            PlateauPartie.Name = "PlateauPartie";
            PlateauPartie.TabIndex = 0;
            PlateauPartie.Dock = System.Windows.Forms.DockStyle.Fill;
            PlateauPartie.Location = new System.Drawing.Point(0, 0);
            PlateauPartie.Size = new System.Drawing.Size(800, 600);

            // 
            // Partie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PlateauPartie);
            Name = "Partie";
            Text = "Partie";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PlateauPartie;
    }
}