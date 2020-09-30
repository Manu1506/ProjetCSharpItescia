using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetCSharpItescia.Data;
using ProjetCSharpItescia.IHM;
using ProjetCSharpItescia.NEf;
using ProjetCSharpItescia.Utils;

namespace ProjetCSharpItescia
{
    public partial class Form1 : Form
    {
        private EnvoiMail formEnvoiMail;
        private CreateNewCampagne formNewCampagne;
        private string selectedCampagne;
        private string selectedPath;

        public Form1()
        {
            InitializeComponent();
            var dbContext = new ContextEf();
            var allCampagnes = dbContext.Set<Campagne>();
            foreach (var campagne in allCampagnes) listBoxCampagne.Items.Add(campagne.NomCampagne);
            listBoxCampagne.DoubleClick += listBoxCampagne_DoubleClick;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
            emailButton.Enabled = false;
            toolStripRemoveCampagne.Enabled = false;
        }


        /// <summary>
        ///     Action quand on clique sur le bouton "Création d'une campagne"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateNewCampagne_Click(object sender, EventArgs e)
        {
            formNewCampagne = new CreateNewCampagne();
            formNewCampagne.Show();
            formNewCampagne.FormClosed += FormNewCampagne_FormClosed;
        }

        /// <summary>
        ///     Lorsque la fenêtre de création de campagne est fermé, on réactive les boutons de la fenêtre principale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNewCampagne_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("Formulaire de création de campagne fermé");
            listBoxCampagne.Items.Clear();
            var dbContext = new ContextEf();
            var allCampagnes = dbContext.Set<Campagne>();
            foreach (var campagne in allCampagnes) listBoxCampagne.Items.Add(campagne.NomCampagne);
        }

        /// <summary>
        ///     Remplir le tableau lorsqu'on double clique sur une des campagnes dans la liste des campagnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCampagne_DoubleClick(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var nomCampagne = listBoxCampagne.GetItemText(listBoxCampagne.SelectedItem);

            var dbContext = new ContextEf();
            var findCampagne = dbContext.CampagnesEntites.Find(nomCampagne);
            var path = findCampagne.ListeEmail;
            selectedPath = findCampagne.ListeEmail;
            selectedCampagne = findCampagne.NomCampagne;
            Debug.WriteLine("Chemin liste adresse email : " + path);
            try
            {
                var lines = File.ReadAllLines(path);
                if (lines.Length > 0)
                {
                    var firstLine = lines[0];
                    var headerLabels = firstLine.Split(',');
                    foreach (var headerWord in headerLabels) dt.Columns.Add(new DataColumn(headerWord));

                    for (var i = 1; i < lines.Length; i++)
                    {
                        var dataWords = lines[i].Split(',');
                        var dr = dt.NewRow();
                        var columnIndex = 0;
                        foreach (var headerWord in headerLabels) dr[headerWord] = dataWords[columnIndex++];
                        dt.Rows.Add(dr);
                    }
                }

                if (dt.Rows.Count > 1) dataGridView1.DataSource = dt;

                emailButton.Enabled = true;
                toolStripRemoveCampagne.Enabled = true;
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException)
                    MessageBox.Show("Erreur : Le fichier est introuvable",
                        "Ouverture d'une campagne");

                if (ex is ArgumentException)
                    MessageBox.Show("Erreur : Le format du csv est incorrect",
                        "Ouverture d'une campagne");
            }
        }

        /// <summary>
        ///     Sauvegarder les emails du tableau dans un fichier csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSauvegardeEmail_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var validEmail = true;

            var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                var valueCell = (string) cells.Select(cell => cell.Value).ToArray().GetValue(0);
                if (!string.IsNullOrWhiteSpace(valueCell))
                {
                    if (Util.IsValidEmail(valueCell))
                        sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value).ToArray()));
                    else
                        validEmail = false;
                }
            }

            var file = new StreamWriter(selectedPath);
            file.WriteLine(sb.ToString());
            file.Close();
            if (validEmail)
            {
                MessageBox.Show("La liste des email a été mise à jour",
                    "Sauvegarde");

            }
            else
            {

                MessageBox.Show(
                    "La liste des email a été mise à jour" + Environment.NewLine +
                    "Attention : la liste contenait des adresses mail invalide qui ont été supprimé.",
                    "Sauvegarde");

            }

            listBoxCampagne.Items.Clear();
            var dbContext = new ContextEf();
            var allCampagnes = dbContext.Set<Campagne>();
            foreach (var campagne in allCampagnes) listBoxCampagne.Items.Add(campagne.NomCampagne);

        }

        /// <summary>
        ///     Ouvre la fenetre d'envoi d'un mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailButton_Click(object sender, EventArgs e)
        {
            listBoxCampagne.Enabled = false;
            dataGridView1.Enabled = false;

            formEnvoiMail = new EnvoiMail(selectedPath);
            formEnvoiMail.FormClosed += FormEnvoiMail_FormClosed;
            formEnvoiMail.Show();
        }

        /// <summary>
        ///     On reactive les boutons de la fenêtre principale lorsque la fenetre d'envoi d'un mail se ferme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEnvoiMail_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBoxCampagne.Enabled = true;
            dataGridView1.Enabled = true;
        }

        /// <summary>
        ///     Bouton pour ouvrir la fenetre de création d'une nouvelle campagne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newCampagneToolStrip_Click(object sender, EventArgs e)
        {
            formNewCampagne = new CreateNewCampagne();
            formNewCampagne.Show();
            formNewCampagne.FormClosed += FormNewCampagne_FormClosed;
        }

        /// <summary>
        ///     Bouton pour ouvrir la fenetre d'envoi d'un mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void envoiMaillToolStrip_Click(object sender, EventArgs e)
        {
            listBoxCampagne.Enabled = false;
            dataGridView1.Enabled = false;

            formEnvoiMail = new EnvoiMail(selectedPath);
            formEnvoiMail.FormClosed += FormEnvoiMail_FormClosed;
            formEnvoiMail.Show();
        }


        /// <summary>
        ///     Boutton de suppression d'une campagne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripRemoveCampagne_Click(object sender, EventArgs e)
        {
            Debug.Write("Suppression campagne");
            var dbContext = new ContextEf();
            var campagneToRemove = new Campagne {NomCampagne = selectedCampagne};
            dbContext.CampagnesEntites.Attach(campagneToRemove);
            dbContext.CampagnesEntites.Remove(campagneToRemove);
            dbContext.SaveChanges();
            listBoxCampagne.Items.Clear();
            var allCampagnes = dbContext.Set<Campagne>();
            foreach (var campagne in allCampagnes) listBoxCampagne.Items.Add(campagne.NomCampagne);
        }

        /// <summary>
        ///     Boutton d'exportation d'une liste de mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExporter_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();

            var sb = new StringBuilder();

            saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
                sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    var valueCell = (string) cells.Select(cell => cell.Value).ToArray().GetValue(0);
                    if (!string.IsNullOrWhiteSpace(valueCell))
                        sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value).ToArray()));
                }

                var file = new StreamWriter(Path.GetFullPath(saveFileDialog1.FileName));
                file.WriteLine(sb.ToString());
                file.Close();

                MessageBox.Show("Le fichier a bien été exporté",
                    "Exportation");
            }
        }
    }
}