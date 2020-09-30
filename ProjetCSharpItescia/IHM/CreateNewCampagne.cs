using System;
using System.Diagnostics;
using System.Windows.Forms;
using ProjetCSharpItescia.Data;
using ProjetCSharpItescia.NEf;

namespace ProjetCSharpItescia.IHM
{
    public partial class CreateNewCampagne : Form
    {
        public CreateNewCampagne()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boutton parcourir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bouttonParcourir_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    parcourirTextBox.Text = filePath;
                }
            }
        }

        /// <summary>
        /// Bouton de validation de création d'une campagne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("La camapgne" + textBoxNomCampagne.Text + " a bien été sauvegarder");
            var dbContext = new ContextEf();
            var newCampagne = new Campagne(textBoxNomCampagne.Text, parcourirTextBox.Text);
            dbContext.CampagnesEntites.Add(newCampagne);
            dbContext.SaveChanges();
            Close();
        }
    }
}