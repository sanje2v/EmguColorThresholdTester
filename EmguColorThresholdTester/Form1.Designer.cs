namespace EmguColorThresholdTester
{
    partial class frmMain
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
            this.trackHueLow = new System.Windows.Forms.TrackBar();
            this.trackSatLow = new System.Windows.Forms.TrackBar();
            this.trackValLow = new System.Windows.Forms.TrackBar();
            this.lblHueLow = new System.Windows.Forms.Label();
            this.lblSatLow = new System.Windows.Forms.Label();
            this.lblValLow = new System.Windows.Forms.Label();
            this.lblValHigh = new System.Windows.Forms.Label();
            this.lblSatHigh = new System.Windows.Forms.Label();
            this.lblHueHigh = new System.Windows.Forms.Label();
            this.trackValHigh = new System.Windows.Forms.TrackBar();
            this.trackSatHigh = new System.Windows.Forms.TrackBar();
            this.trackHueHigh = new System.Windows.Forms.TrackBar();
            this.lnkBlog = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackHueLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSatLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackValLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackValHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSatHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHueHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // trackHueLow
            // 
            this.trackHueLow.Location = new System.Drawing.Point(90, 12);
            this.trackHueLow.Maximum = 180;
            this.trackHueLow.Name = "trackHueLow";
            this.trackHueLow.Size = new System.Drawing.Size(1193, 45);
            this.trackHueLow.TabIndex = 1;
            this.trackHueLow.Scroll += new System.EventHandler(this.trackHueLow_Scroll);
            // 
            // trackSatLow
            // 
            this.trackSatLow.Location = new System.Drawing.Point(90, 116);
            this.trackSatLow.Maximum = 255;
            this.trackSatLow.Name = "trackSatLow";
            this.trackSatLow.Size = new System.Drawing.Size(1193, 45);
            this.trackSatLow.TabIndex = 5;
            this.trackSatLow.Scroll += new System.EventHandler(this.trackSatLow_Scroll);
            // 
            // trackValLow
            // 
            this.trackValLow.Location = new System.Drawing.Point(90, 227);
            this.trackValLow.Maximum = 255;
            this.trackValLow.Name = "trackValLow";
            this.trackValLow.Size = new System.Drawing.Size(1193, 45);
            this.trackValLow.TabIndex = 9;
            this.trackValLow.Scroll += new System.EventHandler(this.trackValLow_Scroll);
            // 
            // lblHueLow
            // 
            this.lblHueLow.AutoSize = true;
            this.lblHueLow.Location = new System.Drawing.Point(11, 20);
            this.lblHueLow.Name = "lblHueLow";
            this.lblHueLow.Size = new System.Drawing.Size(72, 13);
            this.lblHueLow.TabIndex = 0;
            this.lblHueLow.Text = "Low Hue = 0°";
            // 
            // lblSatLow
            // 
            this.lblSatLow.AutoSize = true;
            this.lblSatLow.Location = new System.Drawing.Point(11, 125);
            this.lblSatLow.Name = "lblSatLow";
            this.lblSatLow.Size = new System.Drawing.Size(64, 13);
            this.lblSatLow.TabIndex = 4;
            this.lblSatLow.Text = "Low Sat = 0";
            // 
            // lblValLow
            // 
            this.lblValLow.AutoSize = true;
            this.lblValLow.Location = new System.Drawing.Point(12, 236);
            this.lblValLow.Name = "lblValLow";
            this.lblValLow.Size = new System.Drawing.Size(63, 13);
            this.lblValLow.TabIndex = 8;
            this.lblValLow.Text = "Low Val = 0";
            // 
            // lblValHigh
            // 
            this.lblValHigh.AutoSize = true;
            this.lblValHigh.Location = new System.Drawing.Point(12, 277);
            this.lblValHigh.Name = "lblValHigh";
            this.lblValHigh.Size = new System.Drawing.Size(65, 13);
            this.lblValHigh.TabIndex = 10;
            this.lblValHigh.Text = "High Val = 0";
            // 
            // lblSatHigh
            // 
            this.lblSatHigh.AutoSize = true;
            this.lblSatHigh.Location = new System.Drawing.Point(11, 164);
            this.lblSatHigh.Name = "lblSatHigh";
            this.lblSatHigh.Size = new System.Drawing.Size(66, 13);
            this.lblSatHigh.TabIndex = 6;
            this.lblSatHigh.Text = "High Sat = 0";
            // 
            // lblHueHigh
            // 
            this.lblHueHigh.AutoSize = true;
            this.lblHueHigh.Location = new System.Drawing.Point(11, 53);
            this.lblHueHigh.Name = "lblHueHigh";
            this.lblHueHigh.Size = new System.Drawing.Size(74, 13);
            this.lblHueHigh.TabIndex = 2;
            this.lblHueHigh.Text = "High Hue = 0°";
            // 
            // trackValHigh
            // 
            this.trackValHigh.Location = new System.Drawing.Point(90, 268);
            this.trackValHigh.Maximum = 255;
            this.trackValHigh.Name = "trackValHigh";
            this.trackValHigh.Size = new System.Drawing.Size(1193, 45);
            this.trackValHigh.TabIndex = 11;
            this.trackValHigh.Scroll += new System.EventHandler(this.trackValHigh_Scroll);
            // 
            // trackSatHigh
            // 
            this.trackSatHigh.Location = new System.Drawing.Point(90, 164);
            this.trackSatHigh.Maximum = 255;
            this.trackSatHigh.Name = "trackSatHigh";
            this.trackSatHigh.Size = new System.Drawing.Size(1193, 45);
            this.trackSatHigh.TabIndex = 7;
            this.trackSatHigh.Scroll += new System.EventHandler(this.trackSatHigh_Scroll);
            // 
            // trackHueHigh
            // 
            this.trackHueHigh.Location = new System.Drawing.Point(90, 54);
            this.trackHueHigh.Maximum = 180;
            this.trackHueHigh.Name = "trackHueHigh";
            this.trackHueHigh.Size = new System.Drawing.Size(1193, 45);
            this.trackHueHigh.TabIndex = 3;
            this.trackHueHigh.Scroll += new System.EventHandler(this.trackHueHigh_Scroll);
            // 
            // lnkBlog
            // 
            this.lnkBlog.AutoSize = true;
            this.lnkBlog.Location = new System.Drawing.Point(11, 329);
            this.lnkBlog.Name = "lnkBlog";
            this.lnkBlog.Size = new System.Drawing.Size(154, 13);
            this.lnkBlog.TabIndex = 14;
            this.lnkBlog.TabStop = true;
            this.lnkBlog.Text = "http://sanje2v.wordpress.com/";
            this.lnkBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBlog_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "This program was written by Sanjeev Sharma. Distributed with GNU License.";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(1183, 312);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 21);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Copy Values";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 349);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkBlog);
            this.Controls.Add(this.lblValHigh);
            this.Controls.Add(this.lblSatHigh);
            this.Controls.Add(this.lblHueHigh);
            this.Controls.Add(this.trackValHigh);
            this.Controls.Add(this.trackSatHigh);
            this.Controls.Add(this.trackHueHigh);
            this.Controls.Add(this.lblValLow);
            this.Controls.Add(this.lblSatLow);
            this.Controls.Add(this.lblHueLow);
            this.Controls.Add(this.trackValLow);
            this.Controls.Add(this.trackSatLow);
            this.Controls.Add(this.trackHueLow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 500);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Color Threshold Tester";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackHueLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSatLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackValLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackValHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSatHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHueHigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackHueLow;
        private System.Windows.Forms.TrackBar trackSatLow;
        private System.Windows.Forms.TrackBar trackValLow;
        private System.Windows.Forms.Label lblHueLow;
        private System.Windows.Forms.Label lblSatLow;
        private System.Windows.Forms.Label lblValLow;
        private System.Windows.Forms.Label lblValHigh;
        private System.Windows.Forms.Label lblSatHigh;
        private System.Windows.Forms.Label lblHueHigh;
        private System.Windows.Forms.TrackBar trackValHigh;
        private System.Windows.Forms.TrackBar trackSatHigh;
        private System.Windows.Forms.TrackBar trackHueHigh;
        private System.Windows.Forms.LinkLabel lnkBlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
    }
}

