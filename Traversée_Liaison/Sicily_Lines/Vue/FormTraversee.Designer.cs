namespace Sicily_Lines.Vue
{
    partial class FormTraversee
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
            this.lbTraversee = new System.Windows.Forms.ListBox();
            this.BoutonUpdate = new System.Windows.Forms.Button();
            this.BoutonSupp = new System.Windows.Forms.Button();
            this.BoutonAdd = new System.Windows.Forms.Button();
            this.gpUpdate = new System.Windows.Forms.GroupBox();
            this.labelHeureMAJ = new System.Windows.Forms.Label();
            this.labelDateMAJ = new System.Windows.Forms.Label();
            this.tbHeureMAJ = new System.Windows.Forms.TextBox();
            this.tbDateMAJ = new System.Windows.Forms.TextBox();
            this.gpSupp = new System.Windows.Forms.GroupBox();
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.labelHeure = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.tbHeure = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbIdTrav = new System.Windows.Forms.TextBox();
            this.cbBateau = new System.Windows.Forms.ComboBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.gpUpdate.SuspendLayout();
            this.gpSupp.SuspendLayout();
            this.gpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTraversee
            // 
            this.lbTraversee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTraversee.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbTraversee.FormattingEnabled = true;
            this.lbTraversee.ItemHeight = 17;
            this.lbTraversee.Location = new System.Drawing.Point(56, 26);
            this.lbTraversee.Name = "lbTraversee";
            this.lbTraversee.Size = new System.Drawing.Size(580, 259);
            this.lbTraversee.TabIndex = 0;
            // 
            // BoutonUpdate
            // 
            this.BoutonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BoutonUpdate.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.BoutonUpdate.ForeColor = System.Drawing.Color.Black;
            this.BoutonUpdate.Location = new System.Drawing.Point(53, 124);
            this.BoutonUpdate.Name = "BoutonUpdate";
            this.BoutonUpdate.Size = new System.Drawing.Size(122, 64);
            this.BoutonUpdate.TabIndex = 1;
            this.BoutonUpdate.Text = "Mise à jour";
            this.BoutonUpdate.UseVisualStyleBackColor = false;
            this.BoutonUpdate.Click += new System.EventHandler(this.BoutonUpdate_Click);
            // 
            // BoutonSupp
            // 
            this.BoutonSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BoutonSupp.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.BoutonSupp.Location = new System.Drawing.Point(50, 93);
            this.BoutonSupp.Name = "BoutonSupp";
            this.BoutonSupp.Size = new System.Drawing.Size(130, 62);
            this.BoutonSupp.TabIndex = 2;
            this.BoutonSupp.Text = "Supprimer";
            this.BoutonSupp.UseVisualStyleBackColor = false;
            this.BoutonSupp.Click += new System.EventHandler(this.BoutonSupp_Click);
            // 
            // BoutonAdd
            // 
            this.BoutonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BoutonAdd.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.BoutonAdd.Location = new System.Drawing.Point(25, 152);
            this.BoutonAdd.Name = "BoutonAdd";
            this.BoutonAdd.Size = new System.Drawing.Size(110, 42);
            this.BoutonAdd.TabIndex = 3;
            this.BoutonAdd.Text = "Ajouter";
            this.BoutonAdd.UseVisualStyleBackColor = false;
            this.BoutonAdd.Click += new System.EventHandler(this.BoutonAdd_Click);
            // 
            // gpUpdate
            // 
            this.gpUpdate.Controls.Add(this.labelHeureMAJ);
            this.gpUpdate.Controls.Add(this.labelDateMAJ);
            this.gpUpdate.Controls.Add(this.tbHeureMAJ);
            this.gpUpdate.Controls.Add(this.tbDateMAJ);
            this.gpUpdate.Controls.Add(this.BoutonUpdate);
            this.gpUpdate.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.gpUpdate.Location = new System.Drawing.Point(367, 330);
            this.gpUpdate.Name = "gpUpdate";
            this.gpUpdate.Size = new System.Drawing.Size(241, 211);
            this.gpUpdate.TabIndex = 4;
            this.gpUpdate.TabStop = false;
            this.gpUpdate.Text = "Mise à jour";
            // 
            // labelHeureMAJ
            // 
            this.labelHeureMAJ.AutoSize = true;
            this.labelHeureMAJ.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelHeureMAJ.Location = new System.Drawing.Point(152, 71);
            this.labelHeureMAJ.Name = "labelHeureMAJ";
            this.labelHeureMAJ.Size = new System.Drawing.Size(45, 17);
            this.labelHeureMAJ.TabIndex = 5;
            this.labelHeureMAJ.Text = "Heure";
            // 
            // labelDateMAJ
            // 
            this.labelDateMAJ.AutoSize = true;
            this.labelDateMAJ.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelDateMAJ.Location = new System.Drawing.Point(152, 38);
            this.labelDateMAJ.Name = "labelDateMAJ";
            this.labelDateMAJ.Size = new System.Drawing.Size(37, 17);
            this.labelDateMAJ.TabIndex = 4;
            this.labelDateMAJ.Text = "Date";
            // 
            // tbHeureMAJ
            // 
            this.tbHeureMAJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbHeureMAJ.Location = new System.Drawing.Point(29, 71);
            this.tbHeureMAJ.Name = "tbHeureMAJ";
            this.tbHeureMAJ.Size = new System.Drawing.Size(100, 25);
            this.tbHeureMAJ.TabIndex = 3;
            // 
            // tbDateMAJ
            // 
            this.tbDateMAJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbDateMAJ.Location = new System.Drawing.Point(29, 35);
            this.tbDateMAJ.Name = "tbDateMAJ";
            this.tbDateMAJ.Size = new System.Drawing.Size(100, 25);
            this.tbDateMAJ.TabIndex = 2;
            // 
            // gpSupp
            // 
            this.gpSupp.Controls.Add(this.BoutonSupp);
            this.gpSupp.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.gpSupp.Location = new System.Drawing.Point(642, 330);
            this.gpSupp.Name = "gpSupp";
            this.gpSupp.Size = new System.Drawing.Size(236, 211);
            this.gpSupp.TabIndex = 5;
            this.gpSupp.TabStop = false;
            this.gpSupp.Text = "Suppression";
            // 
            // gpAdd
            // 
            this.gpAdd.Controls.Add(this.labelHeure);
            this.gpAdd.Controls.Add(this.labelDate);
            this.gpAdd.Controls.Add(this.label1);
            this.gpAdd.Controls.Add(this.labelId);
            this.gpAdd.Controls.Add(this.tbHeure);
            this.gpAdd.Controls.Add(this.tbDate);
            this.gpAdd.Controls.Add(this.tbIdTrav);
            this.gpAdd.Controls.Add(this.cbBateau);
            this.gpAdd.Controls.Add(this.BoutonAdd);
            this.gpAdd.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.gpAdd.Location = new System.Drawing.Point(56, 330);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(296, 211);
            this.gpAdd.TabIndex = 6;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Insertion";
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelHeure.Location = new System.Drawing.Point(149, 129);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(45, 17);
            this.labelHeure.TabIndex = 11;
            this.labelHeure.Text = "Heure";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelDate.Location = new System.Drawing.Point(152, 98);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 17);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(209, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bateau";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelId.Location = new System.Drawing.Point(149, 35);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(82, 17);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "Id Traversée";
            // 
            // tbHeure
            // 
            this.tbHeure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbHeure.Location = new System.Drawing.Point(25, 124);
            this.tbHeure.Name = "tbHeure";
            this.tbHeure.Size = new System.Drawing.Size(100, 25);
            this.tbHeure.TabIndex = 7;
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbDate.Location = new System.Drawing.Point(25, 93);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 25);
            this.tbDate.TabIndex = 6;
            // 
            // tbIdTrav
            // 
            this.tbIdTrav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbIdTrav.Location = new System.Drawing.Point(25, 32);
            this.tbIdTrav.Name = "tbIdTrav";
            this.tbIdTrav.Size = new System.Drawing.Size(100, 25);
            this.tbIdTrav.TabIndex = 5;
            // 
            // cbBateau
            // 
            this.cbBateau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbBateau.FormattingEnabled = true;
            this.cbBateau.Location = new System.Drawing.Point(25, 63);
            this.cbBateau.Name = "cbBateau";
            this.cbBateau.Size = new System.Drawing.Size(178, 25);
            this.cbBateau.TabIndex = 4;
            // 
            // btQuitter
            // 
            this.btQuitter.BackColor = System.Drawing.Color.White;
            this.btQuitter.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.ForeColor = System.Drawing.Color.Red;
            this.btQuitter.Location = new System.Drawing.Point(692, 130);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(120, 53);
            this.btQuitter.TabIndex = 7;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // FormTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(891, 553);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.gpAdd);
            this.Controls.Add(this.gpSupp);
            this.Controls.Add(this.gpUpdate);
            this.Controls.Add(this.lbTraversee);
            this.Name = "FormTraversee";
            this.Text = "FormTraversee";
            this.Load += new System.EventHandler(this.FormTraversee_Load);
            this.gpUpdate.ResumeLayout(false);
            this.gpUpdate.PerformLayout();
            this.gpSupp.ResumeLayout(false);
            this.gpAdd.ResumeLayout(false);
            this.gpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTraversee;
        private System.Windows.Forms.Button BoutonUpdate;
        private System.Windows.Forms.Button BoutonSupp;
        private System.Windows.Forms.Button BoutonAdd;
        private System.Windows.Forms.GroupBox gpUpdate;
        private System.Windows.Forms.GroupBox gpSupp;
        private System.Windows.Forms.GroupBox gpAdd;
        private System.Windows.Forms.TextBox tbHeureMAJ;
        private System.Windows.Forms.TextBox tbDateMAJ;
        private System.Windows.Forms.Label labelHeureMAJ;
        private System.Windows.Forms.Label labelDateMAJ;
        private System.Windows.Forms.TextBox tbIdTrav;
        private System.Windows.Forms.ComboBox cbBateau;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox tbHeure;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuitter;
    }
}