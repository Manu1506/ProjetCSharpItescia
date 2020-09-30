namespace ProjetCSharpItescia.IHM
{
    partial class EnvoiMail
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
            this.labelExpediteur = new System.Windows.Forms.Label();
            this.richTextBoxContenuMail = new System.Windows.Forms.RichTextBox();
            this.labelObjetMail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxObjet = new System.Windows.Forms.TextBox();
            this.labelContenuMail = new System.Windows.Forms.Label();
            this.groupBoxEnvoiMail = new System.Windows.Forms.GroupBox();
            this.textBoxNomExpediteur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxTLS = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPortSMTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPasswordSMTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUtilisateurSMTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServeurSMTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnvoiMail = new System.Windows.Forms.Button();
            this.buttonEnvoiMailTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMailTest = new System.Windows.Forms.TextBox();
            this.groupBoxEnvoiMail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExpediteur
            // 
            this.labelExpediteur.AutoSize = true;
            this.labelExpediteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelExpediteur.Location = new System.Drawing.Point(6, 29);
            this.labelExpediteur.Name = "labelExpediteur";
            this.labelExpediteur.Size = new System.Drawing.Size(42, 17);
            this.labelExpediteur.TabIndex = 0;
            this.labelExpediteur.Text = "Email";
            // 
            // richTextBoxContenuMail
            // 
            this.richTextBoxContenuMail.Location = new System.Drawing.Point(144, 156);
            this.richTextBoxContenuMail.Name = "richTextBoxContenuMail";
            this.richTextBoxContenuMail.Size = new System.Drawing.Size(424, 323);
            this.richTextBoxContenuMail.TabIndex = 1;
            this.richTextBoxContenuMail.Text = "";
            // 
            // labelObjetMail
            // 
            this.labelObjetMail.AutoSize = true;
            this.labelObjetMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelObjetMail.Location = new System.Drawing.Point(6, 103);
            this.labelObjetMail.Name = "labelObjetMail";
            this.labelObjetMail.Size = new System.Drawing.Size(91, 17);
            this.labelObjetMail.TabIndex = 2;
            this.labelObjetMail.Text = "Objet du mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(144, 29);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(424, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxObjet
            // 
            this.textBoxObjet.Location = new System.Drawing.Point(144, 103);
            this.textBoxObjet.Name = "textBoxObjet";
            this.textBoxObjet.Size = new System.Drawing.Size(424, 20);
            this.textBoxObjet.TabIndex = 4;
            // 
            // labelContenuMail
            // 
            this.labelContenuMail.AutoSize = true;
            this.labelContenuMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelContenuMail.Location = new System.Drawing.Point(6, 157);
            this.labelContenuMail.Name = "labelContenuMail";
            this.labelContenuMail.Size = new System.Drawing.Size(110, 17);
            this.labelContenuMail.TabIndex = 5;
            this.labelContenuMail.Text = "Contenu du mail";
            // 
            // groupBoxEnvoiMail
            // 
            this.groupBoxEnvoiMail.Controls.Add(this.textBoxNomExpediteur);
            this.groupBoxEnvoiMail.Controls.Add(this.label5);
            this.groupBoxEnvoiMail.Controls.Add(this.labelContenuMail);
            this.groupBoxEnvoiMail.Controls.Add(this.textBoxObjet);
            this.groupBoxEnvoiMail.Controls.Add(this.textBoxEmail);
            this.groupBoxEnvoiMail.Controls.Add(this.labelObjetMail);
            this.groupBoxEnvoiMail.Controls.Add(this.richTextBoxContenuMail);
            this.groupBoxEnvoiMail.Controls.Add(this.labelExpediteur);
            this.groupBoxEnvoiMail.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEnvoiMail.Name = "groupBoxEnvoiMail";
            this.groupBoxEnvoiMail.Size = new System.Drawing.Size(585, 535);
            this.groupBoxEnvoiMail.TabIndex = 6;
            this.groupBoxEnvoiMail.TabStop = false;
            this.groupBoxEnvoiMail.Text = "Envoi de l\'email";
            // 
            // textBoxNomExpediteur
            // 
            this.textBoxNomExpediteur.Location = new System.Drawing.Point(144, 63);
            this.textBoxNomExpediteur.Name = "textBoxNomExpediteur";
            this.textBoxNomExpediteur.Size = new System.Drawing.Size(424, 20);
            this.textBoxNomExpediteur.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nom de l\'expéditeur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxTLS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxPortSMTP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPasswordSMTP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxUtilisateurSMTP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxServeurSMTP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(603, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 211);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres SMTP";
            // 
            // checkBoxTLS
            // 
            this.checkBoxTLS.AutoSize = true;
            this.checkBoxTLS.Location = new System.Drawing.Point(121, 179);
            this.checkBoxTLS.Name = "checkBoxTLS";
            this.checkBoxTLS.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTLS.TabIndex = 9;
            this.checkBoxTLS.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "TLS";
            // 
            // textBoxPortSMTP
            // 
            this.textBoxPortSMTP.Location = new System.Drawing.Point(121, 138);
            this.textBoxPortSMTP.Name = "textBoxPortSMTP";
            this.textBoxPortSMTP.Size = new System.Drawing.Size(210, 20);
            this.textBoxPortSMTP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port";
            // 
            // textBoxPasswordSMTP
            // 
            this.textBoxPasswordSMTP.Location = new System.Drawing.Point(121, 97);
            this.textBoxPasswordSMTP.Name = "textBoxPasswordSMTP";
            this.textBoxPasswordSMTP.Size = new System.Drawing.Size(210, 20);
            this.textBoxPasswordSMTP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe";
            // 
            // textBoxUtilisateurSMTP
            // 
            this.textBoxUtilisateurSMTP.Location = new System.Drawing.Point(121, 62);
            this.textBoxUtilisateurSMTP.Name = "textBoxUtilisateurSMTP";
            this.textBoxUtilisateurSMTP.Size = new System.Drawing.Size(210, 20);
            this.textBoxUtilisateurSMTP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Utilisateur";
            // 
            // textBoxServeurSMTP
            // 
            this.textBoxServeurSMTP.Location = new System.Drawing.Point(121, 25);
            this.textBoxServeurSMTP.Name = "textBoxServeurSMTP";
            this.textBoxServeurSMTP.Size = new System.Drawing.Size(210, 20);
            this.textBoxServeurSMTP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serveur SMTP";
            // 
            // buttonEnvoiMail
            // 
            this.buttonEnvoiMail.Location = new System.Drawing.Point(628, 393);
            this.buttonEnvoiMail.Name = "buttonEnvoiMail";
            this.buttonEnvoiMail.Size = new System.Drawing.Size(315, 112);
            this.buttonEnvoiMail.TabIndex = 8;
            this.buttonEnvoiMail.Text = "Envoyer le mail";
            this.buttonEnvoiMail.UseVisualStyleBackColor = true;
            this.buttonEnvoiMail.Click += new System.EventHandler(this.buttonEnvoiMail_Click);
            // 
            // buttonEnvoiMailTest
            // 
            this.buttonEnvoiMailTest.Location = new System.Drawing.Point(16, 95);
            this.buttonEnvoiMailTest.Name = "buttonEnvoiMailTest";
            this.buttonEnvoiMailTest.Size = new System.Drawing.Size(315, 38);
            this.buttonEnvoiMailTest.TabIndex = 9;
            this.buttonEnvoiMailTest.Text = "Envoyer un mail de test";
            this.buttonEnvoiMailTest.UseVisualStyleBackColor = true;
            this.buttonEnvoiMailTest.Click += new System.EventHandler(this.buttonEnvoiMailTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMailTest);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonEnvoiMailTest);
            this.groupBox2.Location = new System.Drawing.Point(612, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 139);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email de test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(13, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mail de test ";
            // 
            // textBoxMailTest
            // 
            this.textBoxMailTest.Location = new System.Drawing.Point(112, 36);
            this.textBoxMailTest.Name = "textBoxMailTest";
            this.textBoxMailTest.Size = new System.Drawing.Size(210, 20);
            this.textBoxMailTest.TabIndex = 11;
            // 
            // EnvoiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonEnvoiMail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEnvoiMail);
            this.Name = "EnvoiMail";
            this.Text = "EnvoiMail";
            this.groupBoxEnvoiMail.ResumeLayout(false);
            this.groupBoxEnvoiMail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelExpediteur;
        private System.Windows.Forms.RichTextBox richTextBoxContenuMail;
        private System.Windows.Forms.Label labelObjetMail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxObjet;
        private System.Windows.Forms.Label labelContenuMail;
        private System.Windows.Forms.GroupBox groupBoxEnvoiMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPasswordSMTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUtilisateurSMTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServeurSMTP;
        private System.Windows.Forms.TextBox textBoxPortSMTP;
        private System.Windows.Forms.Button buttonEnvoiMail;
        private System.Windows.Forms.TextBox textBoxNomExpediteur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxTLS;
        private System.Windows.Forms.Button buttonEnvoiMailTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMailTest;
        private System.Windows.Forms.Label label7;
    }
}