namespace PhoneComparisonHome
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnHome = new System.Windows.Forms.Button();
            this.grpHmBox = new System.Windows.Forms.GroupBox();
            this.btnKnowledge = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.picBackImg = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpHmBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(218, 156);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // grpHmBox
            // 
            this.grpHmBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpHmBox.Controls.Add(this.btnKnowledge);
            this.grpHmBox.Controls.Add(this.btnHome);
            this.grpHmBox.Controls.Add(this.btnPhone);
            this.grpHmBox.Location = new System.Drawing.Point(1, 0);
            this.grpHmBox.Name = "grpHmBox";
            this.grpHmBox.Size = new System.Drawing.Size(218, 469);
            this.grpHmBox.TabIndex = 0;
            this.grpHmBox.TabStop = false;
            // 
            // btnKnowledge
            // 
            this.btnKnowledge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKnowledge.FlatAppearance.BorderSize = 0;
            this.btnKnowledge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKnowledge.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKnowledge.Location = new System.Drawing.Point(0, 315);
            this.btnKnowledge.Name = "btnKnowledge";
            this.btnKnowledge.Size = new System.Drawing.Size(218, 156);
            this.btnKnowledge.TabIndex = 2;
            this.btnKnowledge.Text = "Knowledge Center";
            this.btnKnowledge.UseVisualStyleBackColor = false;
            // 
            // btnPhone
            // 
            this.btnPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPhone.FlatAppearance.BorderSize = 0;
            this.btnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhone.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhone.Location = new System.Drawing.Point(0, 156);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(218, 158);
            this.btnPhone.TabIndex = 1;
            this.btnPhone.Text = "Phone Comparison";
            this.btnPhone.UseVisualStyleBackColor = false;
            // 
            // picBackImg
            // 
            this.picBackImg.Image = global::PhoneComparisonHome.Properties.Resources.home_background;
            this.picBackImg.Location = new System.Drawing.Point(219, 0);
            this.picBackImg.Name = "picBackImg";
            this.picBackImg.Size = new System.Drawing.Size(612, 469);
            this.picBackImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackImg.TabIndex = 1;
            this.picBackImg.TabStop = false;
            this.picBackImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(410, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBackImg);
            this.Controls.Add(this.grpHmBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "Phone Comparison";
            this.grpHmBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox grpHmBox;
        private System.Windows.Forms.Button btnKnowledge;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.PictureBox picBackImg;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

