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
            tableLayoutPanelRules = new TableLayoutPanel();
            tableLayoutPanelRules.SuspendLayout();
            SuspendLayout();
            // 
            // detailsRegles
            // 
            detailsRegles.AllowDrop = true;
            detailsRegles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            detailsRegles.AutoSize = true;
            detailsRegles.BackColor = Color.Transparent;
            detailsRegles.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            detailsRegles.ForeColor = Color.White;
            detailsRegles.Location = new Point(0, 205);
            detailsRegles.Margin = new Padding(0);
            detailsRegles.Name = "detailsRegles";
            detailsRegles.Size = new Size(959, 358);
            detailsRegles.TabIndex = 0;
            detailsRegles.Text = resources.GetString("detailsRegles.Text");
            detailsRegles.TextAlign = ContentAlignment.MiddleLeft;
            detailsRegles.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Young Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(953, 67);
            label2.TabIndex = 1;
            label2.Text = "Règles du jeu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelRules
            // 
            tableLayoutPanelRules.BackColor = Color.Transparent;
            tableLayoutPanelRules.ColumnCount = 1;
            tableLayoutPanelRules.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRules.Controls.Add(label2, 0, 0);
            tableLayoutPanelRules.Controls.Add(detailsRegles, 0, 1);
            tableLayoutPanelRules.Dock = DockStyle.Fill;
            tableLayoutPanelRules.Location = new Point(0, 0);
            tableLayoutPanelRules.Name = "tableLayoutPanelRules";
            tableLayoutPanelRules.RowCount = 2;
            tableLayoutPanelRules.RowStyles.Add(new RowStyle());
            tableLayoutPanelRules.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRules.Size = new Size(959, 563);
            tableLayoutPanelRules.TabIndex = 2;
            // 
            // Regles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(959, 563);
            Controls.Add(tableLayoutPanelRules);
            Name = "Regles";
            Text = "Regles";
            tableLayoutPanelRules.ResumeLayout(false);
            tableLayoutPanelRules.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label detailsRegles;
        private Label label2;
        private TableLayoutPanel tableLayoutPanelRules;
    }
}