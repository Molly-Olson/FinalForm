using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalForm
{
    public partial class CrystalGallery : Form
    {
        public CrystalGallery()
        {
            InitializeComponent();
        }

        private void lblAmethyst_Click(object sender, EventArgs e)
        {
            AmethystDetails gallery = new AmethystDetails();
            gallery.ShowDialog();
        }
        private void lblRose_Click(object sender, EventArgs e)
        {
            RoseDetails gallery = new RoseDetails();
            gallery.ShowDialog();
        }
        private void lblLapis_Click(object sender, EventArgs e)
        {
            LapisDetails gallery = new LapisDetails();
            gallery.ShowDialog();
        }
        private void lblCitrine_Click(object sender, EventArgs e)
        {
            CitrineDetails gallery = new CitrineDetails();
            gallery.ShowDialog();
        }
    }
}
