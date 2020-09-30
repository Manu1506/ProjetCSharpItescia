namespace ProjetCSharpItescia
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCampagneToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.envoiMaillToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonCreateNewCampagne = new System.Windows.Forms.ToolStripButton();
            this.emailButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripRemoveCampagne = new System.Windows.Forms.ToolStripButton();
            this.listBoxCampagne = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.buttonSauvegardeEmail = new System.Windows.Forms.Button();
            this.buttonExporter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCampagneToolStrip,
            this.envoiMaillToolStrip});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // newCampagneToolStrip
            // 
            this.newCampagneToolStrip.Name = "newCampagneToolStrip";
            this.newCampagneToolStrip.Size = new System.Drawing.Size(232, 22);
            this.newCampagneToolStrip.Text = "Créer une nouvelle campagne";
            this.newCampagneToolStrip.Click += new System.EventHandler(this.newCampagneToolStrip_Click);
            // 
            // envoiMaillToolStrip
            // 
            this.envoiMaillToolStrip.Name = "envoiMaillToolStrip";
            this.envoiMaillToolStrip.Size = new System.Drawing.Size(232, 22);
            this.envoiMaillToolStrip.Text = "Envoi de mail";
            this.envoiMaillToolStrip.Click += new System.EventHandler(this.envoiMaillToolStrip_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonCreateNewCampagne,
            this.emailButton,
            this.toolStripRemoveCampagne});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonCreateNewCampagne
            // 
            this.buttonCreateNewCampagne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCreateNewCampagne.Image = global::ProjetCSharpItescia.Properties.Resources.create;
            this.buttonCreateNewCampagne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCreateNewCampagne.Name = "buttonCreateNewCampagne";
            this.buttonCreateNewCampagne.Size = new System.Drawing.Size(23, 22);
            this.buttonCreateNewCampagne.Text = "toolStripButton1";
            this.buttonCreateNewCampagne.Click += new System.EventHandler(this.buttonCreateNewCampagne_Click);
            // 
            // emailButton
            // 
            this.emailButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emailButton.Image = global::ProjetCSharpItescia.Properties.Resources.email;
            this.emailButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(23, 22);
            this.emailButton.Text = "toolStripButton1";
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // toolStripRemoveCampagne
            // 
            this.toolStripRemoveCampagne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRemoveCampagne.Image = global::ProjetCSharpItescia.Properties.Resources.remove;
            this.toolStripRemoveCampagne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRemoveCampagne.Name = "toolStripRemoveCampagne";
            this.toolStripRemoveCampagne.Size = new System.Drawing.Size(23, 22);
            this.toolStripRemoveCampagne.Text = "toolStripButton1";
            this.toolStripRemoveCampagne.Click += new System.EventHandler(this.toolStripRemoveCampagne_Click);
            // 
            // listBoxCampagne
            // 
            this.listBoxCampagne.FormattingEnabled = true;
            this.listBoxCampagne.Location = new System.Drawing.Point(0, 52);
            this.listBoxCampagne.Name = "listBoxCampagne";
            this.listBoxCampagne.Size = new System.Drawing.Size(257, 394);
            this.listBoxCampagne.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 365);
            this.dataGridView1.TabIndex = 3;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // buttonSauvegardeEmail
            // 
            this.buttonSauvegardeEmail.Location = new System.Drawing.Point(525, 417);
            this.buttonSauvegardeEmail.Name = "buttonSauvegardeEmail";
            this.buttonSauvegardeEmail.Size = new System.Drawing.Size(275, 29);
            this.buttonSauvegardeEmail.TabIndex = 4;
            this.buttonSauvegardeEmail.Text = "Sauvegarder les adresses mails";
            this.buttonSauvegardeEmail.UseVisualStyleBackColor = true;
            this.buttonSauvegardeEmail.Click += new System.EventHandler(this.buttonSauvegardeEmail_Click);
            // 
            // buttonExporter
            // 
            this.buttonExporter.Location = new System.Drawing.Point(254, 417);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(273, 29);
            this.buttonExporter.TabIndex = 5;
            this.buttonExporter.Text = "Exporter";
            this.buttonExporter.UseVisualStyleBackColor = true;
            this.buttonExporter.Click += new System.EventHandler(this.buttonExporter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.buttonExporter);
            this.Controls.Add(this.buttonSauvegardeEmail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxCampagne);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion de campagne";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonCreateNewCampagne;
        private System.Windows.Forms.ListBox listBoxCampagne;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button buttonSauvegardeEmail;
        private System.Windows.Forms.ToolStripButton emailButton;
        private System.Windows.Forms.ToolStripMenuItem newCampagneToolStrip;
        private System.Windows.Forms.ToolStripMenuItem envoiMaillToolStrip;
        private System.Windows.Forms.Button buttonExporter;
        private System.Windows.Forms.ToolStripButton toolStripRemoveCampagne;
    }
}

