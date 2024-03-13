namespace AtYarisiYeni
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            saha = new Panel();
            at3 = new PictureBox();
            at2 = new PictureBox();
            at1 = new PictureBox();
            bitis = new PictureBox();
            btnBaslat = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblSpiker = new Label();
            saha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)at3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bitis).BeginInit();
            SuspendLayout();
            // 
            // saha
            // 
            saha.BackColor = Color.Green;
            saha.Controls.Add(at3);
            saha.Controls.Add(at2);
            saha.Controls.Add(at1);
            saha.Controls.Add(bitis);
            saha.Location = new Point(47, 12);
            saha.Name = "saha";
            saha.Size = new Size(773, 469);
            saha.TabIndex = 0;
            // 
            // at3
            // 
            at3.Image = (Image)resources.GetObject("at3.Image");
            at3.Location = new Point(0, 327);
            at3.Name = "at3";
            at3.Size = new Size(125, 78);
            at3.SizeMode = PictureBoxSizeMode.Zoom;
            at3.TabIndex = 2;
            at3.TabStop = false;
            at3.Tag = "3";
            // 
            // at2
            // 
            at2.Image = (Image)resources.GetObject("at2.Image");
            at2.Location = new Point(0, 196);
            at2.Name = "at2";
            at2.Size = new Size(125, 78);
            at2.SizeMode = PictureBoxSizeMode.Zoom;
            at2.TabIndex = 1;
            at2.TabStop = false;
            at2.Tag = "2";
            // 
            // at1
            // 
            at1.Image = (Image)resources.GetObject("at1.Image");
            at1.Location = new Point(0, 65);
            at1.Name = "at1";
            at1.Size = new Size(125, 78);
            at1.SizeMode = PictureBoxSizeMode.Zoom;
            at1.TabIndex = 0;
            at1.TabStop = false;
            at1.Tag = "1";
            // 
            // bitis
            // 
            bitis.Image = (Image)resources.GetObject("bitis.Image");
            bitis.Location = new Point(665, 0);
            bitis.Name = "bitis";
            bitis.Size = new Size(78, 469);
            bitis.TabIndex = 3;
            bitis.TabStop = false;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(247, 558);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(379, 52);
            btnBaslat.TabIndex = 1;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblSpiker
            // 
            lblSpiker.Font = new Font("Impact", 16F);
            lblSpiker.Location = new Point(47, 493);
            lblSpiker.Name = "lblSpiker";
            lblSpiker.Size = new Size(773, 56);
            lblSpiker.TabIndex = 2;
            lblSpiker.Text = "Atlar yarışa hazır..";
            lblSpiker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 622);
            Controls.Add(lblSpiker);
            Controls.Add(btnBaslat);
            Controls.Add(saha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "At Yarışı";
            saha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)at3).EndInit();
            ((System.ComponentModel.ISupportInitialize)at2).EndInit();
            ((System.ComponentModel.ISupportInitialize)at1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bitis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel saha;
        private PictureBox at1;
        private PictureBox at3;
        private PictureBox at2;
        private PictureBox bitis;
        private Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
        private Label lblSpiker;
    }
}
