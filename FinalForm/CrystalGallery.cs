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
        // changed lables to buttons that once clicked will bring you to a detalis page for each rock.
        // there has to be something better than just another text box for paragraphs
        private void btnAmethyst_Click_1(object sender, EventArgs e)
        {
            AmethystDetails gallery = new AmethystDetails();
            gallery.ShowDialog();
        }

        private void btnLapis_Click(object sender, EventArgs e)
        {
            LapisDetails gallery = new LapisDetails();
            gallery.ShowDialog();
        }

        private void btnRose_Click(object sender, EventArgs e)
        {
            RoseDetails gallery = new RoseDetails();
            gallery.ShowDialog();
        }

        private void btnCitrine_Click(object sender, EventArgs e)
        {
            CitrineDetails gallery = new CitrineDetails();
            gallery.ShowDialog();
        }

        private void btnMoldavite_Click(object sender, EventArgs e)
        {
            MoldaviteDetails gallery = new MoldaviteDetails();
            gallery.ShowDialog();
        }

        private void btnObsidian_Click(object sender, EventArgs e)
        {
            ObsidianDetails gallery = new ObsidianDetails();
            gallery.ShowDialog();
        }
    }
}
