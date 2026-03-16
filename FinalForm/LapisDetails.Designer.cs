namespace FinalForm
{
    partial class LapisDetails
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
            lblLapis = new Label();
            lblDetails = new Label();
            SuspendLayout();
            // 
            // lblLapis
            // 
            lblLapis.AutoSize = true;
            lblLapis.Location = new Point(358, 35);
            lblLapis.Name = "lblLapis";
            lblLapis.Size = new Size(43, 20);
            lblLapis.TabIndex = 0;
            lblLapis.Text = "Lapis";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(212, 74);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(325, 20);
            lblDetails.TabIndex = 1;
            lblDetails.Text = "This is where I tell you how cool this blue rock is";
            // 
            // LapisDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDetails);
            Controls.Add(lblLapis);
            Name = "LapisDetails";
            Text = "LapisDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLapis;
        private Label lblDetails;
    }
}