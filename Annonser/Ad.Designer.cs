namespace Annonser
{
    partial class Ad
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cboCategori = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdMyAd = new System.Windows.Forms.Button();
            this.cmdEditAd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.txtInfoDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInfoTitel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLocationInfo = new System.Windows.Forms.TextBox();
            this.txtPriceInfo = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 228);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cboCategori
            // 
            this.cboCategori.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategori.FormattingEnabled = true;
            this.cboCategori.Location = new System.Drawing.Point(12, 59);
            this.cboCategori.Name = "cboCategori";
            this.cboCategori.Size = new System.Drawing.Size(183, 24);
            this.cboCategori.TabIndex = 1;
            this.cboCategori.SelectedIndexChanged += new System.EventHandler(this.cboCategori_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(201, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Location = new System.Drawing.Point(427, 59);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(84, 22);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.Text = "Sök";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(24, 371);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(89, 31);
            this.cmdLogin.TabIndex = 5;
            this.cmdLogin.Text = "Logga in";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdMyAd
            // 
            this.cmdMyAd.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMyAd.Location = new System.Drawing.Point(119, 371);
            this.cmdMyAd.Name = "cmdMyAd";
            this.cmdMyAd.Size = new System.Drawing.Size(125, 31);
            this.cmdMyAd.TabIndex = 7;
            this.cmdMyAd.Text = "Mina annonser";
            this.cmdMyAd.UseVisualStyleBackColor = true;
            this.cmdMyAd.Visible = false;
            this.cmdMyAd.Click += new System.EventHandler(this.cmdMyAd_Click);
            // 
            // cmdEditAd
            // 
            this.cmdEditAd.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditAd.Location = new System.Drawing.Point(250, 371);
            this.cmdEditAd.Name = "cmdEditAd";
            this.cmdEditAd.Size = new System.Drawing.Size(197, 31);
            this.cmdEditAd.TabIndex = 8;
            this.cmdEditAd.Text = "Lägg till/Ändra/Ta bort annons";
            this.cmdEditAd.UseVisualStyleBackColor = true;
            this.cmdEditAd.Visible = false;
            this.cmdEditAd.Click += new System.EventHandler(this.cmdEditAd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSeller);
            this.groupBox3.Location = new System.Drawing.Point(565, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 77);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Säljes av...";
            // 
            // txtSeller
            // 
            this.txtSeller.Location = new System.Drawing.Point(17, 38);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(133, 22);
            this.txtSeller.TabIndex = 3;
            this.txtSeller.Text = "Användare";
            // 
            // txtInfoDescription
            // 
            this.txtInfoDescription.Location = new System.Drawing.Point(17, 49);
            this.txtInfoDescription.Multiline = true;
            this.txtInfoDescription.Name = "txtInfoDescription";
            this.txtInfoDescription.Size = new System.Drawing.Size(390, 142);
            this.txtInfoDescription.TabIndex = 10;
            this.txtInfoDescription.Text = "Beskrivning";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInfoTitel);
            this.groupBox1.Controls.Add(this.txtInfoDescription);
            this.groupBox1.Location = new System.Drawing.Point(565, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 217);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtInfoTitel
            // 
            this.txtInfoTitel.Location = new System.Drawing.Point(17, 21);
            this.txtInfoTitel.Name = "txtInfoTitel";
            this.txtInfoTitel.Size = new System.Drawing.Size(390, 22);
            this.txtInfoTitel.TabIndex = 4;
            this.txtInfoTitel.Text = "Titel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLocationInfo);
            this.groupBox2.Controls.Add(this.txtPriceInfo);
            this.groupBox2.Location = new System.Drawing.Point(565, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 53);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // txtLocationInfo
            // 
            this.txtLocationInfo.Location = new System.Drawing.Point(181, 18);
            this.txtLocationInfo.Name = "txtLocationInfo";
            this.txtLocationInfo.Size = new System.Drawing.Size(133, 22);
            this.txtLocationInfo.TabIndex = 6;
            this.txtLocationInfo.Text = "Plats";
            // 
            // txtPriceInfo
            // 
            this.txtPriceInfo.Location = new System.Drawing.Point(17, 18);
            this.txtPriceInfo.Name = "txtPriceInfo";
            this.txtPriceInfo.Size = new System.Drawing.Size(133, 22);
            this.txtPriceInfo.TabIndex = 5;
            this.txtPriceInfo.Text = "Pris";
            // 
            // Ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdEditAd);
            this.Controls.Add(this.cmdMyAd);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboCategori);
            this.Controls.Add(this.listBox1);
            this.Name = "Ad";
            this.Text = "Annonser";
            this.Load += new System.EventHandler(this.Ad_Load);
            this.Shown += new System.EventHandler(this.Ad_Show);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cboCategori;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdMyAd;
        private System.Windows.Forms.Button cmdEditAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.TextBox txtInfoDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInfoTitel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLocationInfo;
        private System.Windows.Forms.TextBox txtPriceInfo;
    }
}

