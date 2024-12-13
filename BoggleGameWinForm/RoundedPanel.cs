using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BoggleGameWinForm
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 20; // Rayon des coins arrondis
        public Color FillColor { get; set; } = Color.FromArgb(128, 255, 255, 255); // Blanc semi-transparent (opacité 0.5)

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                // Dessiner les coins arrondis
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                path.CloseFigure();

                // Remplir avec la couleur
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(FillColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
    }
}
