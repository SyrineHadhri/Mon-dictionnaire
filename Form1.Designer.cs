namespace Samesem_Dictionary
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labErreur = new System.Windows.Forms.Label();
            this.picErreur = new System.Windows.Forms.PictureBox();
            this.listBoxMots = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttDone = new System.Windows.Forms.Button();
            this.buttEcouter = new System.Windows.Forms.Button();
            this.buttVocale = new System.Windows.Forms.Button();
            this.txtDefinition = new System.Windows.Forms.RichTextBox();
            this.txtMot = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErreur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Samesem_Dictionary.Properties.Resources.fenetre;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labErreur);
            this.panel1.Controls.Add(this.picErreur);
            this.panel1.Controls.Add(this.listBoxMots);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttDone);
            this.panel1.Controls.Add(this.buttEcouter);
            this.panel1.Controls.Add(this.buttVocale);
            this.panel1.Controls.Add(this.txtDefinition);
            this.panel1.Controls.Add(this.txtMot);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 605);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Samesem_Dictionary.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(225, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // labErreur
            // 
            this.labErreur.AutoSize = true;
            this.labErreur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(198)))), ((int)(((byte)(184)))));
            this.labErreur.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labErreur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labErreur.Location = new System.Drawing.Point(626, 156);
            this.labErreur.Name = "labErreur";
            this.labErreur.Size = new System.Drawing.Size(285, 20);
            this.labErreur.TabIndex = 14;
            this.labErreur.Text = "Entrer que des caractéres alphabétiques";
            this.labErreur.Visible = false;
            this.labErreur.Click += new System.EventHandler(this.label2_Click);
            // 
            // picErreur
            // 
            this.picErreur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(198)))), ((int)(((byte)(184)))));
            this.picErreur.Image = global::Samesem_Dictionary.Properties.Resources.Button_Close_icon1;
            this.picErreur.Location = new System.Drawing.Point(577, 140);
            this.picErreur.Name = "picErreur";
            this.picErreur.Size = new System.Drawing.Size(43, 43);
            this.picErreur.TabIndex = 12;
            this.picErreur.TabStop = false;
            this.picErreur.Visible = false;
            this.picErreur.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // listBoxMots
            // 
            this.listBoxMots.Font = new System.Drawing.Font("Lucida Calligraphy", 12F);
            this.listBoxMots.FormattingEnabled = true;
            this.listBoxMots.ItemHeight = 21;
            this.listBoxMots.Location = new System.Drawing.Point(77, 184);
            this.listBoxMots.Name = "listBoxMots";
            this.listBoxMots.Size = new System.Drawing.Size(181, 340);
            this.listBoxMots.TabIndex = 11;
            this.listBoxMots.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Samesem_Dictionary.Properties.Resources.dictionnaire;
            this.pictureBox1.Location = new System.Drawing.Point(802, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 79);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttDone
            // 
            this.buttDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(198)))), ((int)(((byte)(184)))));
            this.buttDone.Image = global::Samesem_Dictionary.Properties.Resources.Done_Logo;
            this.buttDone.Location = new System.Drawing.Point(466, 140);
            this.buttDone.Name = "buttDone";
            this.buttDone.Size = new System.Drawing.Size(101, 53);
            this.buttDone.TabIndex = 9;
            this.buttDone.UseVisualStyleBackColor = false;
            // 
            // buttEcouter
            // 
            this.buttEcouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(198)))), ((int)(((byte)(184)))));
            this.buttEcouter.Image = global::Samesem_Dictionary.Properties.Resources.ecoute;
            this.buttEcouter.Location = new System.Drawing.Point(405, 140);
            this.buttEcouter.Name = "buttEcouter";
            this.buttEcouter.Size = new System.Drawing.Size(55, 53);
            this.buttEcouter.TabIndex = 8;
            this.buttEcouter.UseVisualStyleBackColor = false;
            // 
            // buttVocale
            // 
            this.buttVocale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(198)))), ((int)(((byte)(184)))));
            this.buttVocale.Image = global::Samesem_Dictionary.Properties.Resources._05105916_photo_logo_reconnaissance_vocale_google_1074430829_01230349;
            this.buttVocale.Location = new System.Drawing.Point(346, 140);
            this.buttVocale.Name = "buttVocale";
            this.buttVocale.Size = new System.Drawing.Size(53, 53);
            this.buttVocale.TabIndex = 7;
            this.buttVocale.UseVisualStyleBackColor = false;
            // 
            // txtDefinition
            // 
            this.txtDefinition.Font = new System.Drawing.Font("Lucida Calligraphy", 12F);
            this.txtDefinition.Location = new System.Drawing.Point(346, 212);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(537, 292);
            this.txtDefinition.TabIndex = 4;
            this.txtDefinition.Text = "";
            this.txtDefinition.TextChanged += new System.EventHandler(this.txtDefinition_TextChanged);
            // 
            // txtMot
            // 
            this.txtMot.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.Location = new System.Drawing.Point(77, 129);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(181, 31);
            this.txtMot.TabIndex = 1;
            this.txtMot.Text = "";
            this.txtMot.TextChanged += new System.EventHandler(this.txtMot_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 597);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErreur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtDefinition;
        private System.Windows.Forms.RichTextBox txtMot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttDone;
        private System.Windows.Forms.Button buttEcouter;
        private System.Windows.Forms.Button buttVocale;
        private System.Windows.Forms.ListBox listBoxMots;
        private System.Windows.Forms.PictureBox picErreur;
        private System.Windows.Forms.Label labErreur;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

