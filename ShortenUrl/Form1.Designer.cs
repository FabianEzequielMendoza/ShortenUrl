namespace ShortenUrl
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TBInsertUrl = new System.Windows.Forms.TextBox();
            this.BtnShorterUrl = new System.Windows.Forms.Button();
            this.linklbShortURL = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBHashId = new System.Windows.Forms.TextBox();
            this.TBLongUrl = new System.Windows.Forms.TextBox();
            this.TBCreatedAt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBShortUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert URL";
            // 
            // TBInsertUrl
            // 
            this.TBInsertUrl.Location = new System.Drawing.Point(196, 81);
            this.TBInsertUrl.Name = "TBInsertUrl";
            this.TBInsertUrl.Size = new System.Drawing.Size(468, 20);
            this.TBInsertUrl.TabIndex = 1;
            // 
            // BtnShorterUrl
            // 
            this.BtnShorterUrl.Location = new System.Drawing.Point(309, 323);
            this.BtnShorterUrl.Name = "BtnShorterUrl";
            this.BtnShorterUrl.Size = new System.Drawing.Size(152, 68);
            this.BtnShorterUrl.TabIndex = 3;
            this.BtnShorterUrl.Text = "Shorten URL !";
            this.BtnShorterUrl.UseVisualStyleBackColor = true;
            this.BtnShorterUrl.Click += new System.EventHandler(this.BtnShorterUrl_Click);
            // 
            // linklbShortURL
            // 
            this.linklbShortURL.AutoSize = true;
            this.linklbShortURL.Location = new System.Drawing.Point(193, 284);
            this.linklbShortURL.Name = "linklbShortURL";
            this.linklbShortURL.Size = new System.Drawing.Size(18, 13);
            this.linklbShortURL.TabIndex = 7;
            this.linklbShortURL.TabStop = true;
            this.linklbShortURL.Text = "url";
            this.linklbShortURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbShortURL_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hash id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Long url";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Created at";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Short url";
            // 
            // TBHashId
            // 
            this.TBHashId.Location = new System.Drawing.Point(196, 122);
            this.TBHashId.Name = "TBHashId";
            this.TBHashId.ReadOnly = true;
            this.TBHashId.Size = new System.Drawing.Size(468, 20);
            this.TBHashId.TabIndex = 12;
            // 
            // TBLongUrl
            // 
            this.TBLongUrl.Location = new System.Drawing.Point(196, 162);
            this.TBLongUrl.Name = "TBLongUrl";
            this.TBLongUrl.ReadOnly = true;
            this.TBLongUrl.Size = new System.Drawing.Size(468, 20);
            this.TBLongUrl.TabIndex = 13;
            // 
            // TBCreatedAt
            // 
            this.TBCreatedAt.Location = new System.Drawing.Point(196, 202);
            this.TBCreatedAt.Name = "TBCreatedAt";
            this.TBCreatedAt.ReadOnly = true;
            this.TBCreatedAt.Size = new System.Drawing.Size(468, 20);
            this.TBCreatedAt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Go to";
            // 
            // TBShortUrl
            // 
            this.TBShortUrl.Location = new System.Drawing.Point(196, 241);
            this.TBShortUrl.Name = "TBShortUrl";
            this.TBShortUrl.ReadOnly = true;
            this.TBShortUrl.Size = new System.Drawing.Size(468, 20);
            this.TBShortUrl.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBShortUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBCreatedAt);
            this.Controls.Add(this.TBLongUrl);
            this.Controls.Add(this.TBHashId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linklbShortURL);
            this.Controls.Add(this.BtnShorterUrl);
            this.Controls.Add(this.TBInsertUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ShortenURL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBInsertUrl;
        private System.Windows.Forms.Button BtnShorterUrl;
        private System.Windows.Forms.LinkLabel linklbShortURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBHashId;
        private System.Windows.Forms.TextBox TBLongUrl;
        private System.Windows.Forms.TextBox TBCreatedAt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBShortUrl;
    }
}

