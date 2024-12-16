using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class De
    {
        #region Attributs
        private char[] faces = new char[6];
        private char faceVisible;
        #endregion

        #region Proprietes
        public char[] Faces
        {
            get { return this.faces; }
            set
            {
                if (value == null || value.Length != 6) throw new ArgumentException("Un dé doit avoir exactement 6 faces.");
                this.faces = value;
            }
        }

        public char FaceVisible
        {
            get { return this.faceVisible; }
            private set { this.faceVisible = value; }
        }
        #endregion

        #region Constructeurs
        public De(char faceVisible1)
        {
            this.faceVisible = faceVisible1;
        }
        public De(Dictionary<char, int> dicoConfigLettres, List<char> lettresDisponibles, Random random)
        {
            for (int i = 0; i < 6; i++)
            {
                if (lettresDisponibles.Count > 0)
                {
                    int index = random.Next(lettresDisponibles.Count);
                    char lettre = lettresDisponibles[index];

                    Faces[i] = lettre;
                }
                else { Faces[i] = '-'; }
            }

            if (lettresDisponibles.Count > 0)
            {
                this.Lance(dicoConfigLettres, lettresDisponibles, random);
            }
            else
            {
                this.FaceVisible = '-';
            }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Méthode qui lance un Dé pour définir sa face visible
        /// </summary>
        /// <param name="dicoConfigLettres"></param>
        /// <param name="lettresDisponibles"></param>
        /// <param name="random"></param>
        public void Lance(Dictionary<char, int> dicoConfigLettres, List<char> lettresDisponibles, Random random)
        {
            this.FaceVisible = Faces[random.Next(6)];

            // Réduire le compteur de la lettre si elle est visible
            if (dicoConfigLettres.ContainsKey(this.FaceVisible))
            {
                dicoConfigLettres[this.FaceVisible]--;
                if (dicoConfigLettres[this.FaceVisible] == 0)
                {
                    lettresDisponibles.Remove(this.FaceVisible);
                }
            }
        }

        public string toString()
        {
            return $"Visible: {FaceVisible}, Faces: {string.Join(", ", Faces)}";
        }
        #endregion
    }
}