namespace InfoNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_pravda = new System.Windows.Forms.TextBox();
            this.textBox_censor = new System.Windows.Forms.TextBox();
            this.textBox_korrespondent = new System.Windows.Forms.TextBox();
            this.linkLabel_pravda = new System.Windows.Forms.LinkLabel();
            this.linkLabel_censor = new System.Windows.Forms.LinkLabel();
            this.linkLabel_korresp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(760, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Парсить страницы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_pravda
            // 
            this.textBox_pravda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_pravda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pravda.Location = new System.Drawing.Point(12, 41);
            this.textBox_pravda.Multiline = true;
            this.textBox_pravda.Name = "textBox_pravda";
            this.textBox_pravda.ReadOnly = true;
            this.textBox_pravda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_pravda.Size = new System.Drawing.Size(517, 530);
            this.textBox_pravda.TabIndex = 1;
            // 
            // textBox_censor
            // 
            this.textBox_censor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_censor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_censor.Location = new System.Drawing.Point(535, 41);
            this.textBox_censor.Multiline = true;
            this.textBox_censor.Name = "textBox_censor";
            this.textBox_censor.ReadOnly = true;
            this.textBox_censor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_censor.Size = new System.Drawing.Size(517, 530);
            this.textBox_censor.TabIndex = 1;
            // 
            // textBox_korrespondent
            // 
            this.textBox_korrespondent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_korrespondent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_korrespondent.Location = new System.Drawing.Point(1058, 41);
            this.textBox_korrespondent.Multiline = true;
            this.textBox_korrespondent.Name = "textBox_korrespondent";
            this.textBox_korrespondent.ReadOnly = true;
            this.textBox_korrespondent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_korrespondent.Size = new System.Drawing.Size(517, 530);
            this.textBox_korrespondent.TabIndex = 1;
            // 
            // linkLabel_pravda
            // 
            this.linkLabel_pravda.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel_pravda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_pravda.AutoSize = true;
            this.linkLabel_pravda.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_pravda.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel_pravda.Location = new System.Drawing.Point(148, 13);
            this.linkLabel_pravda.Name = "linkLabel_pravda";
            this.linkLabel_pravda.Size = new System.Drawing.Size(240, 25);
            this.linkLabel_pravda.TabIndex = 2;
            this.linkLabel_pravda.TabStop = true;
            this.linkLabel_pravda.Tag = "http:/pda.pravda.com.ua";
            this.linkLabel_pravda.Text = "УКРАЇНСЬКА ПРАВДА";
            this.linkLabel_pravda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_pravda_LinkClicked);
            // 
            // linkLabel_censor
            // 
            this.linkLabel_censor.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel_censor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.linkLabel_censor.AutoSize = true;
            this.linkLabel_censor.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_censor.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel_censor.Location = new System.Drawing.Point(733, 13);
            this.linkLabel_censor.Name = "linkLabel_censor";
            this.linkLabel_censor.Size = new System.Drawing.Size(102, 25);
            this.linkLabel_censor.TabIndex = 2;
            this.linkLabel_censor.TabStop = true;
            this.linkLabel_censor.Tag = "http://m.censor.net.ua";
            this.linkLabel_censor.Text = "ЦЕНЗОР";
            this.linkLabel_censor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_pravda_LinkClicked);
            // 
            // linkLabel_korresp
            // 
            this.linkLabel_korresp.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel_korresp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_korresp.AutoSize = true;
            this.linkLabel_korresp.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_korresp.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel_korresp.Location = new System.Drawing.Point(1214, 13);
            this.linkLabel_korresp.Name = "linkLabel_korresp";
            this.linkLabel_korresp.Size = new System.Drawing.Size(205, 25);
            this.linkLabel_korresp.TabIndex = 2;
            this.linkLabel_korresp.TabStop = true;
            this.linkLabel_korresp.Tag = "http://korrespondent.net";
            this.linkLabel_korresp.Text = "КОРРЕСПОНДЕНТ";
            this.linkLabel_korresp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_pravda_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 618);
            this.Controls.Add(this.linkLabel_korresp);
            this.Controls.Add(this.linkLabel_censor);
            this.Controls.Add(this.linkLabel_pravda);
            this.Controls.Add(this.textBox_korrespondent);
            this.Controls.Add(this.textBox_censor);
            this.Controls.Add(this.textBox_pravda);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1606, 657);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoNews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_pravda;
        private System.Windows.Forms.TextBox textBox_censor;
        private System.Windows.Forms.TextBox textBox_korrespondent;
        private System.Windows.Forms.LinkLabel linkLabel_pravda;
        private System.Windows.Forms.LinkLabel linkLabel_censor;
        private System.Windows.Forms.LinkLabel linkLabel_korresp;
    }
}

