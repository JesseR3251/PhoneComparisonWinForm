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
            this.pnlHome = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSearchPrompt = new System.Windows.Forms.Label();
            this.pnlPhnComp = new System.Windows.Forms.Panel();
            this.lblPhnComp = new System.Windows.Forms.Label();
            this.grpHmBox.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlPhnComp.SuspendLayout();
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.BackgroundImage = global::PhoneComparisonHome.Properties.Resources.home_background;
            this.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHome.Controls.Add(this.pnlPhnComp);
            this.pnlHome.Controls.Add(this.textBox1);
            this.pnlHome.Controls.Add(this.btnSearch);
            this.pnlHome.Controls.Add(this.comboBox1);
            this.pnlHome.Controls.Add(this.lblSearchPrompt);
            this.pnlHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnlHome.Location = new System.Drawing.Point(219, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(605, 469);
            this.pnlHome.TabIndex = 3;
            this.pnlHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(257, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 40);
            this.textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(96)))), ((int)(((byte)(152)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(200, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(266, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Advanced Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Brand"});
            this.comboBox1.Location = new System.Drawing.Point(423, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Name";
            // 
            // lblSearchPrompt
            // 
            this.lblSearchPrompt.AutoSize = true;
            this.lblSearchPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchPrompt.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(96)))), ((int)(((byte)(152)))));
            this.lblSearchPrompt.Location = new System.Drawing.Point(138, 140);
            this.lblSearchPrompt.Name = "lblSearchPrompt";
            this.lblSearchPrompt.Size = new System.Drawing.Size(97, 33);
            this.lblSearchPrompt.TabIndex = 0;
            this.lblSearchPrompt.Text = "Search:";
            // 
            // pnlPhnComp
            // 
            this.pnlPhnComp.BackColor = System.Drawing.Color.White;
            this.pnlPhnComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhnComp.Controls.Add(this.lblPhnComp);
            this.pnlPhnComp.Location = new System.Drawing.Point(0, 0);
            this.pnlPhnComp.Name = "pnlPhnComp";
            this.pnlPhnComp.Size = new System.Drawing.Size(605, 469);
            this.pnlPhnComp.TabIndex = 4;
            // 
            // lblPhnComp
            // 
            this.lblPhnComp.AutoSize = true;
            this.lblPhnComp.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhnComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(96)))), ((int)(((byte)(152)))));
            this.lblPhnComp.Location = new System.Drawing.Point(194, 41);
            this.lblPhnComp.Name = "lblPhnComp";
            this.lblPhnComp.Size = new System.Drawing.Size(227, 33);
            this.lblPhnComp.TabIndex = 0;
            this.lblPhnComp.Text = "Phone Comparison";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 468);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.grpHmBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "Phone Comparison";
            this.grpHmBox.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlPhnComp.ResumeLayout(false);
            this.pnlPhnComp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox grpHmBox;
        private System.Windows.Forms.Button btnKnowledge;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSearchPrompt;
        private System.Windows.Forms.Panel pnlPhnComp;
        private System.Windows.Forms.Label lblPhnComp;
    }
}

