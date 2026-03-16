namespace FinalForm
{
    partial class CrystalGallery
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
            picRose = new PictureBox();
            picAmethyst = new PictureBox();
            picCitrine = new PictureBox();
            picMoldavite = new PictureBox();
            picLapis = new PictureBox();
            pictureBox1 = new PictureBox();
            btnAmethyst = new Button();
            btnLapis = new Button();
            btnRose = new Button();
            btnCitrine = new Button();
            btnMoldavite = new Button();
            btnObsidian = new Button();
            ((System.ComponentModel.ISupportInitialize)picRose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAmethyst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCitrine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMoldavite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLapis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picRose
            // 
            picRose.Image = Properties.Resources.RoseQuartz;
            picRose.Location = new Point(40, 27);
            picRose.Name = "picRose";
            picRose.Size = new Size(191, 184);
            picRose.TabIndex = 0;
            picRose.TabStop = false;
            // 
            // picAmethyst
            // 
            picAmethyst.Image = Properties.Resources.Amethyst;
            picAmethyst.Location = new Point(311, 25);
            picAmethyst.Name = "picAmethyst";
            picAmethyst.Size = new Size(185, 186);
            picAmethyst.TabIndex = 1;
            picAmethyst.TabStop = false;
            // 
            // picCitrine
            // 
            picCitrine.Image = Properties.Resources.Citrine;
            picCitrine.Location = new Point(41, 243);
            picCitrine.Name = "picCitrine";
            picCitrine.Size = new Size(190, 178);
            picCitrine.TabIndex = 2;
            picCitrine.TabStop = false;
            // 
            // picMoldavite
            // 
            picMoldavite.Image = Properties.Resources.Moldavite;
            picMoldavite.Location = new Point(311, 257);
            picMoldavite.Name = "picMoldavite";
            picMoldavite.Size = new Size(182, 164);
            picMoldavite.TabIndex = 3;
            picMoldavite.TabStop = false;
            // 
            // picLapis
            // 
            picLapis.Image = Properties.Resources.Lapis;
            picLapis.Location = new Point(571, 25);
            picLapis.Name = "picLapis";
            picLapis.Size = new Size(189, 184);
            picLapis.TabIndex = 4;
            picLapis.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Obsidian;
            pictureBox1.Location = new Point(550, 271);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 150);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnAmethyst
            // 
            btnAmethyst.Location = new Point(363, 210);
            btnAmethyst.Name = "btnAmethyst";
            btnAmethyst.Size = new Size(94, 29);
            btnAmethyst.TabIndex = 12;
            btnAmethyst.Text = "Amethyst";
            btnAmethyst.UseVisualStyleBackColor = true;
            btnAmethyst.Click += btnAmethyst_Click_1;
            // 
            // btnLapis
            // 
            btnLapis.Location = new Point(616, 215);
            btnLapis.Name = "btnLapis";
            btnLapis.Size = new Size(94, 29);
            btnLapis.TabIndex = 13;
            btnLapis.Text = "Lapis Lazuli";
            btnLapis.UseVisualStyleBackColor = true;
            btnLapis.Click += btnLapis_Click;
            // 
            // btnRose
            // 
            btnRose.Location = new Point(83, 210);
            btnRose.Name = "btnRose";
            btnRose.Size = new Size(102, 29);
            btnRose.TabIndex = 14;
            btnRose.Text = "Rose Quartz";
            btnRose.UseVisualStyleBackColor = true;
            btnRose.Click += btnRose_Click;
            // 
            // btnCitrine
            // 
            btnCitrine.Location = new Point(91, 427);
            btnCitrine.Name = "btnCitrine";
            btnCitrine.Size = new Size(94, 29);
            btnCitrine.TabIndex = 15;
            btnCitrine.Text = "Citrine";
            btnCitrine.UseVisualStyleBackColor = true;
            btnCitrine.Click += btnCitrine_Click;
            // 
            // btnMoldavite
            // 
            btnMoldavite.Location = new Point(363, 427);
            btnMoldavite.Name = "btnMoldavite";
            btnMoldavite.Size = new Size(94, 29);
            btnMoldavite.TabIndex = 16;
            btnMoldavite.Text = "Modavite";
            btnMoldavite.UseVisualStyleBackColor = true;
            btnMoldavite.Click += btnMoldavite_Click;
            // 
            // btnObsidian
            // 
            btnObsidian.Location = new Point(616, 427);
            btnObsidian.Name = "btnObsidian";
            btnObsidian.Size = new Size(94, 29);
            btnObsidian.TabIndex = 17;
            btnObsidian.Text = "Obsidian";
            btnObsidian.UseVisualStyleBackColor = true;
            btnObsidian.Click += btnObsidian_Click;
            // 
            // CrystalGallery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(btnObsidian);
            Controls.Add(btnMoldavite);
            Controls.Add(btnCitrine);
            Controls.Add(btnRose);
            Controls.Add(btnLapis);
            Controls.Add(btnAmethyst);
            Controls.Add(pictureBox1);
            Controls.Add(picLapis);
            Controls.Add(picMoldavite);
            Controls.Add(picCitrine);
            Controls.Add(picAmethyst);
            Controls.Add(picRose);
            Name = "CrystalGallery";
            Text = "CrystalGallery";
            ((System.ComponentModel.ISupportInitialize)picRose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAmethyst).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCitrine).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMoldavite).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLapis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picRose;
        private PictureBox picAmethyst;
        private PictureBox picCitrine;
        private PictureBox picMoldavite;
        private PictureBox picLapis;
        private PictureBox pictureBox1;
        private Button btnAmethyst;
        private Button btnLapis;
        private Button btnRose;
        private Button btnCitrine;
        private Button btnMoldavite;
        private Button btnObsidian;
    }
}