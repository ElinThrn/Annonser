namespace Annonser
{
    partial class EditAd
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmdCreateNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtAdInfo = new System.Windows.Forms.TextBox();
            this.txtAdTitel = new System.Windows.Forms.TextBox();
            this.cmdUpdateAd = new System.Windows.Forms.Button();
            this.cmdDeleteAd = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Plats";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(27, 370);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(421, 22);
            this.txtPrice.TabIndex = 28;
            // 
            // cmdCreateNew
            // 
            this.cmdCreateNew.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreateNew.Location = new System.Drawing.Point(27, 515);
            this.cmdCreateNew.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateNew.Name = "cmdCreateNew";
            this.cmdCreateNew.Size = new System.Drawing.Size(118, 44);
            this.cmdCreateNew.TabIndex = 26;
            this.cmdCreateNew.Text = "Skapa ny";
            this.cmdCreateNew.UseVisualStyleBackColor = true;
            this.cmdCreateNew.Click += new System.EventHandler(this.cmdSaveAd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Beskrivning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Titel";
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(27, 304);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(421, 24);
            this.cboCategory.TabIndex = 22;
            // 
            // txtAdInfo
            // 
            this.txtAdInfo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdInfo.Location = new System.Drawing.Point(27, 97);
            this.txtAdInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdInfo.Multiline = true;
            this.txtAdInfo.Name = "txtAdInfo";
            this.txtAdInfo.Size = new System.Drawing.Size(421, 165);
            this.txtAdInfo.TabIndex = 21;
            // 
            // txtAdTitel
            // 
            this.txtAdTitel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdTitel.Location = new System.Drawing.Point(27, 30);
            this.txtAdTitel.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdTitel.Name = "txtAdTitel";
            this.txtAdTitel.Size = new System.Drawing.Size(421, 22);
            this.txtAdTitel.TabIndex = 20;
            // 
            // cmdUpdateAd
            // 
            this.cmdUpdateAd.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdateAd.Location = new System.Drawing.Point(174, 515);
            this.cmdUpdateAd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdUpdateAd.Name = "cmdUpdateAd";
            this.cmdUpdateAd.Size = new System.Drawing.Size(127, 44);
            this.cmdUpdateAd.TabIndex = 31;
            this.cmdUpdateAd.Text = "Ändra";
            this.cmdUpdateAd.UseVisualStyleBackColor = true;
            // 
            // cmdDeleteAd
            // 
            this.cmdDeleteAd.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteAd.Location = new System.Drawing.Point(329, 515);
            this.cmdDeleteAd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDeleteAd.Name = "cmdDeleteAd";
            this.cmdDeleteAd.Size = new System.Drawing.Size(119, 44);
            this.cmdDeleteAd.TabIndex = 32;
            this.cmdDeleteAd.Text = "Ta bort";
            this.cmdDeleteAd.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(27, 444);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(421, 22);
            this.txtLocation.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Pris";
            // 
            // EditAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmdDeleteAd);
            this.Controls.Add(this.cmdUpdateAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmdCreateNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtAdInfo);
            this.Controls.Add(this.txtAdTitel);
            this.Name = "EditAd";
            this.Text = "EditAd";
            this.Load += new System.EventHandler(this.EditAd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button cmdCreateNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtAdInfo;
        private System.Windows.Forms.TextBox txtAdTitel;
        private System.Windows.Forms.Button cmdUpdateAd;
        private System.Windows.Forms.Button cmdDeleteAd;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label3;
    }
}