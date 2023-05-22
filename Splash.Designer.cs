namespace MobileStore
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.LProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VProgressBar = new Guna.UI2.WinForms.Guna2VProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LProgressBar
            // 
            this.LProgressBar.BorderColor = System.Drawing.Color.White;
            this.LProgressBar.BorderRadius = 1;
            this.LProgressBar.BorderThickness = 3;
            this.LProgressBar.FillColor = System.Drawing.Color.Fuchsia;
            this.LProgressBar.Location = new System.Drawing.Point(-8, 338);
            this.LProgressBar.Name = "LProgressBar";
            this.LProgressBar.ProgressColor = System.Drawing.Color.White;
            this.LProgressBar.ProgressColor2 = System.Drawing.Color.White;
            this.LProgressBar.Size = new System.Drawing.Size(743, 21);
            this.LProgressBar.TabIndex = 0;
            this.LProgressBar.Text = "guna2ProgressBar1";
            this.LProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.LProgressBar.ValueChanged += new System.EventHandler(this.guna2ProgressBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moblie Store version 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VProgressBar
            // 
            this.VProgressBar.BorderColor = System.Drawing.Color.White;
            this.VProgressBar.BorderThickness = 3;
            this.VProgressBar.FillColor = System.Drawing.Color.Fuchsia;
            this.VProgressBar.Location = new System.Drawing.Point(55, -2);
            this.VProgressBar.Name = "VProgressBar";
            this.VProgressBar.ProgressColor = System.Drawing.Color.White;
            this.VProgressBar.ProgressColor2 = System.Drawing.Color.White;
            this.VProgressBar.Size = new System.Drawing.Size(20, 411);
            this.VProgressBar.TabIndex = 4;
            this.VProgressBar.Text = "guna2VProgressBar1";
            this.VProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(736, 411);
            this.Controls.Add(this.VProgressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar LProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2VProgressBar VProgressBar;
    }
}

