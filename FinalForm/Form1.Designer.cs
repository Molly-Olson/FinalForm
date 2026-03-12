namespace FinalForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            pnlCrystal = new Panel();
            btnAddCustomer = new Button();
            label1 = new Label();
            cmbCrystal = new ComboBox();
            lblEmail = new Label();
            lblName = new Label();
            txtEmail = new TextBox();
            lstCustomer = new ListBox();
            btnDetails = new Button();
            btnGallery = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlCrystal);
            groupBox1.Controls.Add(btnAddCustomer);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCrystal);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 148);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pnlCrystal
            // 
            pnlCrystal.Location = new Point(345, 51);
            pnlCrystal.Name = "pnlCrystal";
            pnlCrystal.Size = new Size(175, 91);
            pnlCrystal.TabIndex = 8;
            pnlCrystal.Paint += pnlCrystal_Paint;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(345, 13);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(175, 27);
            btnAddCustomer.TabIndex = 7;
            btnAddCustomer.Text = "Add New Member";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 104);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 5;
            label1.Text = "Favorite Crystal";
            // 
            // cmbCrystal
            // 
            cmbCrystal.FormattingEnabled = true;
            cmbCrystal.Location = new Point(122, 101);
            cmbCrystal.Name = "cmbCrystal";
            cmbCrystal.Size = new Size(151, 28);
            cmbCrystal.TabIndex = 4;
            cmbCrystal.SelectedIndexChanged += cmbCrystal_SelectedIndexChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 62);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 1;
            // 
            // lstCustomer
            // 
            lstCustomer.FormattingEnabled = true;
            lstCustomer.Location = new Point(12, 180);
            lstCustomer.Name = "lstCustomer";
            lstCustomer.Size = new Size(526, 224);
            lstCustomer.TabIndex = 2;
            lstCustomer.SelectedIndexChanged += lstCustomer_SelectedIndexChanged;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(424, 422);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(94, 29);
            btnDetails.TabIndex = 3;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnGallery
            // 
            btnGallery.Location = new Point(39, 422);
            btnGallery.Name = "btnGallery";
            btnGallery.Size = new Size(198, 29);
            btnGallery.TabIndex = 4;
            btnGallery.Text = "Crystal Gallery";
            btnGallery.UseVisualStyleBackColor = true;
            btnGallery.Click += btnGallery_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAddCustomer;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 474);
            Controls.Add(btnGallery);
            Controls.Add(btnDetails);
            Controls.Add(lstCustomer);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Crystal Club";
            Load += Form1_Load;
            Enter += btnAddCustomer_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtName;
        private GroupBox groupBox1;
        private Label lblEmail;
        private Label lblName;
        private TextBox txtEmail;
        private Label label1;
        private ComboBox cmbCrystal;
        private Button btnAddCustomer;
        private ListBox lstCustomer;
        private Button btnDetails;
        private Panel pnlCrystal;
        private Button btnGallery;
    }
}
