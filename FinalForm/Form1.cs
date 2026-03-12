namespace FinalForm
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCrystal.Items.Add("Amethyst");
            cmbCrystal.Items.Add("Rose Quartz");
            cmbCrystal.Items.Add("Citrine");
            cmbCrystal.Items.Add("Obsidian");
            cmbCrystal.Items.Add("Moldavite");
            cmbCrystal.Items.Add("Lapis");

            cmbCrystal.SelectedIndex = 0;  // displays the first crystal in the array as default
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // validating that a name was entered
            if (txtName.Text.Trim() == "") // trim will trim out the empty spaces to allow first and last name in one box
            {
                MessageBox.Show("Please enter a name.");
                return;  // stops the function so as not to allow an empty name to be added
            }
            // validating email was entered correctly or at least contains an @ symbol
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return; // if no @ symbol the function stops and wont add the customer to the list
            }

            Customer c = new Customer();

            c.Name = txtName.Text;
            c.Email = txtEmail.Text;
            c.FavoriteCrystal = cmbCrystal.Text;

            customers.Add(c);

            lstCustomer.Items.Add(c);
            // clear the form when the customer is added to the list box
            txtName.Clear();
            txtEmail.Clear();
            cmbCrystal.SelectedIndex = 0;
        }

        private void pnlCrystal_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point[] crystal =
            {
                // AI usage, I had chatgpt draw this for me
                new Point(87,10),
                new Point(140, 45),
                new Point(87, 81),
                new Point(35, 45)
            };
            // g.FillPolygon(Brushes.MediumPurple, crystal);  // coloring in the dramn gem
            // change the colot of the crystal
            Brush brush = Brushes.Purple;
            if (cmbCrystal.Text == "Amethyst")
                brush = Brushes.Purple;

            if (cmbCrystal.Text == "Rose Quartz")
                brush = Brushes.Pink;

            if (cmbCrystal.Text == "Citrine")
                brush = Brushes.Gold;

            if (cmbCrystal.Text == "Obsidian")
                brush = Brushes.Black;

            if (cmbCrystal.Text == "Moldavite")
                brush = Brushes.DarkSeaGreen;

            if (cmbCrystal.Text == "Lapis")
                brush = Brushes.CornflowerBlue;

            g.FillPolygon(brush, crystal);

            // make the rock look more rock like LOL
            // AI usage, I had chatgpt chose the draw points for this instead of trial and error
            Pen pen = new Pen(Color.White, 2);

            g.DrawLine(pen, 87, 10, 87, 81);
            g.DrawLine(pen, 35, 45, 140, 45);
            g.DrawLine(pen, 87, 10, 35, 45);
            g.DrawLine(pen, 87, 10, 140, 45);

        }

        private void cmbCrystal_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCrystal.Invalidate();  // invalidate says redraw this 
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // view customer details upon click details
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer first.");
                return;  // can't hit the details button without selecting a customer from the lsit box
            }
            // get selected customer
            Customer selected = (Customer)lstCustomer.SelectedItem;
            // show customer details
            string message =
                "Name: " + selected.Name + "\n" +
              "Email: " + selected.Email + "\n" +
              "Favorite Crystal: " + selected.FavoriteCrystal;

            MessageBox.Show(message, "Customer Details: ");

        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            // call the second form "Crystal Gallery"
            CrystalGallery gallery = new CrystalGallery();
            gallery.ShowDialog();
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string FavoriteCrystal { get; set; }

        public override string ToString()
        {
            return Name + " - " + FavoriteCrystal;
        }
    }
}
