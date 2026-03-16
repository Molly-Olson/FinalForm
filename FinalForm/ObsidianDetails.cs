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
    public partial class ObsidianDetails : Form
    {
        public ObsidianDetails()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CrystalGallery gallery = new CrystalGallery();
            gallery.ShowDialog();
            // ok but like now we are making soooo many windows Molly!
            // look up how to do this the way you want
        }
    }
}
