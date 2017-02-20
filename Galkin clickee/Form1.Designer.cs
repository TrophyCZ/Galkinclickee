namespace Galkin_clickee
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Stalin = new System.Windows.Forms.PictureBox();
            this.Lenin = new System.Windows.Forms.PictureBox();
            this.Galkin = new System.Windows.Forms.Label();
            this.Lenintext = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.obnova = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Krymtext = new System.Windows.Forms.Label();
            this.GPSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Stalin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lenin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Stalin
            // 
            this.Stalin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stalin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stalin.BackgroundImage")));
            this.Stalin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stalin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Stalin.ErrorImage")));
            this.Stalin.Location = new System.Drawing.Point(2, 229);
            this.Stalin.Name = "Stalin";
            this.Stalin.Size = new System.Drawing.Size(339, 296);
            this.Stalin.TabIndex = 1;
            this.Stalin.TabStop = false;
            this.Stalin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lenin
            // 
            this.Lenin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lenin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lenin.BackgroundImage")));
            this.Lenin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lenin.Location = new System.Drawing.Point(884, 169);
            this.Lenin.Name = "Lenin";
            this.Lenin.Size = new System.Drawing.Size(109, 186);
            this.Lenin.TabIndex = 2;
            this.Lenin.TabStop = false;
            this.Lenin.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Galkin
            // 
            this.Galkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Galkin.Font = new System.Drawing.Font("Kremlin", 70F);
            this.Galkin.ForeColor = System.Drawing.Color.Red;
            this.Galkin.Location = new System.Drawing.Point(12, 9);
            this.Galkin.Name = "Galkin";
            this.Galkin.Size = new System.Drawing.Size(981, 103);
            this.Galkin.TabIndex = 3;
            this.Galkin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lenintext
            // 
            this.Lenintext.Font = new System.Drawing.Font("Communist", 13F);
            this.Lenintext.ForeColor = System.Drawing.Color.Red;
            this.Lenintext.Location = new System.Drawing.Point(593, 169);
            this.Lenintext.Name = "Lenintext";
            this.Lenintext.Size = new System.Drawing.Size(285, 39);
            this.Lenintext.TabIndex = 4;
            this.Lenintext.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // obnova
            // 
            this.obnova.Enabled = true;
            this.obnova.Interval = 1;
            this.obnova.Tick += new System.EventHandler(this.obnova_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(758, 378);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 147);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Krymtext
            // 
            this.Krymtext.Enabled = false;
            this.Krymtext.Font = new System.Drawing.Font("Communist", 13F);
            this.Krymtext.ForeColor = System.Drawing.Color.Red;
            this.Krymtext.Location = new System.Drawing.Point(453, 378);
            this.Krymtext.Name = "Krymtext";
            this.Krymtext.Size = new System.Drawing.Size(299, 39);
            this.Krymtext.TabIndex = 6;
            this.Krymtext.Click += new System.EventHandler(this.label3_Click);
            // 
            // GPSLabel
            // 
            this.GPSLabel.Font = new System.Drawing.Font("Kremlin", 40F);
            this.GPSLabel.ForeColor = System.Drawing.Color.Red;
            this.GPSLabel.Location = new System.Drawing.Point(347, 229);
            this.GPSLabel.MaximumSize = new System.Drawing.Size(242, 109);
            this.GPSLabel.MinimumSize = new System.Drawing.Size(242, 109);
            this.GPSLabel.Name = "GPSLabel";
            this.GPSLabel.Size = new System.Drawing.Size(242, 109);
            this.GPSLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 537);
            this.Controls.Add(this.GPSLabel);
            this.Controls.Add(this.Krymtext);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Lenintext);
            this.Controls.Add(this.Galkin);
            this.Controls.Add(this.Lenin);
            this.Controls.Add(this.Stalin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Kremlin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1023, 584);
            this.MinimumSize = new System.Drawing.Size(1023, 584);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Stalin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lenin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Stalin;
        private System.Windows.Forms.PictureBox Lenin;
        private System.Windows.Forms.Label Galkin;
        private System.Windows.Forms.Label Lenintext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer obnova;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Krymtext;
        private System.Windows.Forms.Label GPSLabel;
    }
}

