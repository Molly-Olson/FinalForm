namespace FinalForm
{
    partial class ObsidianDetails
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
            lblObsidian = new Label();
            lblDetailsObsidian = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // lblObsidian
            // 
            lblObsidian.AutoSize = true;
            lblObsidian.Location = new Point(341, 9);
            lblObsidian.Name = "lblObsidian";
            lblObsidian.Size = new Size(68, 20);
            lblObsidian.TabIndex = 0;
            lblObsidian.Text = "Obsidian";
            // 
            // lblDetailsObsidian
            // 
            lblDetailsObsidian.AutoSize = true;
            lblDetailsObsidian.Location = new Point(297, 41);
            lblDetailsObsidian.Name = "lblDetailsObsidian";
            lblDetailsObsidian.Size = new Size(179, 20);
            lblDetailsObsidian.TabIndex = 1;
            lblDetailsObsidian.Text = "Obsidian is cool, it's black";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(667, 382);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // ObsidianDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(lblDetailsObsidian);
            Controls.Add(lblObsidian);
            Name = "ObsidianDetails";
            Text = "ObsidianDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblObsidian;
        private Label lblDetailsObsidian;
        private Button btnReturn;
    }
}