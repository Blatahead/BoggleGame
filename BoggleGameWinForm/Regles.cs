﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoggleGameWinForm
{
    public partial class Regles : Form
    {
        #region Constructeur
        public Regles()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("./../../../../background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion
    }
}
