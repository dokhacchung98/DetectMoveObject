using System.Drawing;
using System.Drawing.Text;

namespace BaiTapLon.GUI
{
    partial class FlashScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prbFlashScreen = new MaterialSkin.Controls.MaterialProgressBar();
            this.txtAppName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::BaiTapLon.Properties.Resources.webcam;
            this.pictureBox1.Location = new System.Drawing.Point(176, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // prbFlashScreen
            // 
            this.prbFlashScreen.Depth = 0;
            this.prbFlashScreen.Location = new System.Drawing.Point(12, 271);
            this.prbFlashScreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.prbFlashScreen.Name = "prbFlashScreen";
            this.prbFlashScreen.Size = new System.Drawing.Size(455, 5);
            this.prbFlashScreen.TabIndex = 1;
            // 
            // txtAppName
            // 
            this.txtAppName.AutoSize = true;
            this.txtAppName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAppName.Depth = 0;
            this.txtAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.txtAppName.Location = new System.Drawing.Point(154, 176);
            this.txtAppName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(167, 39);
            this.txtAppName.TabIndex = 2;
            this.txtAppName.Text = "TCT-Cam";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(81, 215);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(323, 20);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Detection of moving objects with Webcam";
            // 
            // FlashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BaiTapLon.Properties.Resources.background_flashscreen;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.prbFlashScreen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialProgressBar prbFlashScreen;
        private MaterialSkin.Controls.MaterialLabel txtAppName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}