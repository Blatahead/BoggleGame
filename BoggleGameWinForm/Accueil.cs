using BoggleGameWinForm;

namespace BoggleGame
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Chargement_Accueil(object sender, EventArgs e)
        {
            int hauteur = Screen.PrimaryScreen.Bounds.Height;
            int largeur = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, 0);
            this.Size = new Size(largeur, hauteur);
        }

        private void ButtonGameClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Merci d'avoir cliqué ! final test");
            Partie partie = new Partie();
            partie.Show();
        }

        private void buttonRulesClick(object sender, EventArgs e)
        {
            Regles regles = new Regles();
            regles.Show();
        }

        private void buttonConfigClick(object sender, EventArgs e)
        {
            Configurations configurations = new Configurations();
            configurations.Show();
        }
    }
}
