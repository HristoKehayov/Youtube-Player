namespace Youtube_Player
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PlayRandomMusic_Btn = new System.Windows.Forms.Button();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.CurrMusic_thumbnail = new System.Windows.Forms.PictureBox();
            this.CurrTitle_of_theMusic = new System.Windows.Forms.Label();
            this.CurrAuthur_of_theMusic = new System.Windows.Forms.Label();
            this.Next_Page_Search_Btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurrMusic_thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 22);
            this.textBox1.TabIndex = 3;
            // 
            // PlayRandomMusic_Btn
            // 
            this.PlayRandomMusic_Btn.Location = new System.Drawing.Point(627, 8);
            this.PlayRandomMusic_Btn.Name = "PlayRandomMusic_Btn";
            this.PlayRandomMusic_Btn.Size = new System.Drawing.Size(147, 30);
            this.PlayRandomMusic_Btn.TabIndex = 6;
            this.PlayRandomMusic_Btn.Text = "Play Random Music";
            this.PlayRandomMusic_Btn.UseVisualStyleBackColor = true;
            this.PlayRandomMusic_Btn.Click += new System.EventHandler(this.PlayRandomMusic_Btn_Click);
            // 
            // Search_Btn
            // 
            this.Search_Btn.Location = new System.Drawing.Point(517, 8);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(104, 30);
            this.Search_Btn.TabIndex = 7;
            this.Search_Btn.Text = "Search Music";
            this.Search_Btn.UseVisualStyleBackColor = true;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // CurrMusic_thumbnail
            // 
            this.CurrMusic_thumbnail.Location = new System.Drawing.Point(12, 78);
            this.CurrMusic_thumbnail.Name = "CurrMusic_thumbnail";
            this.CurrMusic_thumbnail.Size = new System.Drawing.Size(337, 214);
            this.CurrMusic_thumbnail.TabIndex = 8;
            this.CurrMusic_thumbnail.TabStop = false;
            // 
            // CurrTitle_of_theMusic
            // 
            this.CurrTitle_of_theMusic.AutoSize = true;
            this.CurrTitle_of_theMusic.Location = new System.Drawing.Point(26, 361);
            this.CurrTitle_of_theMusic.Name = "CurrTitle_of_theMusic";
            this.CurrTitle_of_theMusic.Size = new System.Drawing.Size(30, 17);
            this.CurrTitle_of_theMusic.TabIndex = 9;
            this.CurrTitle_of_theMusic.Text = "title";
            // 
            // CurrAuthur_of_theMusic
            // 
            this.CurrAuthur_of_theMusic.AutoSize = true;
            this.CurrAuthur_of_theMusic.Location = new System.Drawing.Point(26, 396);
            this.CurrAuthur_of_theMusic.Name = "CurrAuthur_of_theMusic";
            this.CurrAuthur_of_theMusic.Size = new System.Drawing.Size(49, 17);
            this.CurrAuthur_of_theMusic.TabIndex = 10;
            this.CurrAuthur_of_theMusic.Text = "authur";
            // 
            // Next_Page_Search_Btn
            // 
            this.Next_Page_Search_Btn.Location = new System.Drawing.Point(113, 361);
            this.Next_Page_Search_Btn.Name = "Next_Page_Search_Btn";
            this.Next_Page_Search_Btn.Size = new System.Drawing.Size(124, 23);
            this.Next_Page_Search_Btn.TabIndex = 11;
            this.Next_Page_Search_Btn.Text = "Load Next Page";
            this.Next_Page_Search_Btn.UseVisualStyleBackColor = true;
            this.Next_Page_Search_Btn.Click += new System.EventHandler(this.Next_Page_Search_Btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(355, 44);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1018, 648);
            this.webBrowser1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 704);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Next_Page_Search_Btn);
            this.Controls.Add(this.CurrAuthur_of_theMusic);
            this.Controls.Add(this.CurrTitle_of_theMusic);
            this.Controls.Add(this.CurrMusic_thumbnail);
            this.Controls.Add(this.Search_Btn);
            this.Controls.Add(this.PlayRandomMusic_Btn);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Youtube Player";
            ((System.ComponentModel.ISupportInitialize)(this.CurrMusic_thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PlayRandomMusic_Btn;
        private System.Windows.Forms.Button Search_Btn;
        private System.Windows.Forms.PictureBox CurrMusic_thumbnail;
        private System.Windows.Forms.Label CurrTitle_of_theMusic;
        private System.Windows.Forms.Label CurrAuthur_of_theMusic;
        private System.Windows.Forms.Button Next_Page_Search_Btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
    }
}

