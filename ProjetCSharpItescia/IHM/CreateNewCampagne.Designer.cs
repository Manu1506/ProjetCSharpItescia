namespace ProjetCSharpItescia.IHM
{
    partial class CreateNewCampagne
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomCampagne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parcourirTextBox = new System.Windows.Forms.TextBox();
            this.bouttonParcourir = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la campagne";
            // 
            // textBoxNomCampagne
            // 
            this.textBoxNomCampagne.Location = new System.Drawing.Point(211, 21);
            this.textBoxNomCampagne.Name = "textBoxNomCampagne";
            this.textBoxNomCampagne.Size = new System.Drawing.Size(300, 20);
            this.textBoxNomCampagne.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chemin de la liste des mail";
            // 
            // parcourirTextBox
            // 
            this.parcourirTextBox.Location = new System.Drawing.Point(211, 66);
            this.parcourirTextBox.Name = "parcourirTextBox";
            this.parcourirTextBox.Size = new System.Drawing.Size(300, 20);
            this.parcourirTextBox.TabIndex = 3;
            // 
            // bouttonParcourir
            // 
            this.bouttonParcourir.Location = new System.Drawing.Point(526, 66);
            this.bouttonParcourir.Name = "bouttonParcourir";
            this.bouttonParcourir.Size = new System.Drawing.Size(75, 23);
            this.bouttonParcourir.TabIndex = 4;
            this.bouttonParcourir.Text = "Parcourir";
            this.bouttonParcourir.UseVisualStyleBackColor = true;
            this.bouttonParcourir.Click += new System.EventHandler(this.bouttonParcourir_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(526, 112);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 5;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // CreateNewCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 147);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.bouttonParcourir);
            this.Controls.Add(this.parcourirTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomCampagne);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewCampagne";
            this.Text = "CreateNewCampagne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomCampagne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parcourirTextBox;
        private System.Windows.Forms.Button bouttonParcourir;
        private System.Windows.Forms.Button buttonValider;
    }
}