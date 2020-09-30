using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using ProjetCSharpItescia.Utils;

namespace ProjetCSharpItescia.IHM
{
    public partial class EnvoiMail : Form
    {
        private readonly string selectedPath;

        public EnvoiMail(string selectedPath)
        {
            InitializeComponent();
            this.selectedPath = selectedPath;
        }

        /// <summary>
        ///     Action lorsqu'on clique sur le bouton "envoyer un mail"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnvoiMail_Click(object sender, EventArgs e)
        {
            if (checkValiditeChamps())
            {
                var lines = File.ReadAllLines(selectedPath);


                var message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(textBoxEmail.Text, textBoxNomExpediteur.Text);

                foreach (var email in lines)
                    if (Util.IsValidEmail(email))
                        message.Bcc.Add(email);


                message.Subject = textBoxObjet.Text;
                message.Body = richTextBoxContenuMail.Text;

                using (var client = new SmtpClient(textBoxServeurSMTP.Text, Convert.ToInt32(textBoxPortSMTP.Text)))
                {
                    client.Credentials = new NetworkCredential(textBoxUtilisateurSMTP.Text, textBoxPasswordSMTP.Text);
                    if (checkBoxTLS.Checked) client.EnableSsl = true;

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Envoi de mail",
                            "Le mail a bien été envoyé");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur",
                            ex.ToString());

                        Debug.WriteLine("The email was not sent.");
                        Debug.WriteLine("Error message: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        ///     Action lorsqu'on clique sur le bouton "envoyer un mail de test"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnvoiMailTest_Click(object sender, EventArgs e)
        {
            if (checkValiditeChamps())
            {
                var message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(textBoxEmail.Text, textBoxNomExpediteur.Text);

                message.To.Add(textBoxMailTest.Text);

                message.Subject = textBoxObjet.Text;
                message.Body = richTextBoxContenuMail.Text;

                using (var client = new SmtpClient(textBoxServeurSMTP.Text, Convert.ToInt32(textBoxPortSMTP.Text)))
                {
                    client.Credentials = new NetworkCredential(textBoxUtilisateurSMTP.Text, textBoxPasswordSMTP.Text);
                    if (checkBoxTLS.Checked) client.EnableSsl = true;

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Envoi de mail",
                            "Le mail a bien été envoyé");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur",
                            ex.ToString());

                        Debug.WriteLine("The email was not sent.");
                        Debug.WriteLine("Error message: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        ///     Verification de la validité des champs
        /// </summary>
        /// <returns></returns>
        public bool checkValiditeChamps()
        {
            var message = "";
            var tempCheck = true;


            if (!Util.IsValidEmail(textBoxEmail.Text))
            {
                message = " - Le format de l'adresse mail n'est pas valide" + Environment.NewLine;
                tempCheck = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNomExpediteur.Text))
            {
                message = message + "- Le nom de l'expéditeur n'est pas indiqué" + Environment.NewLine;
                tempCheck = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxObjet.Text))
            {
                message = message + "- L'objet du mail n'est pas indiqué" + Environment.NewLine;
                tempCheck = false;
            }

            if (string.IsNullOrWhiteSpace(richTextBoxContenuMail.Text))
            {
                message = message + "- Le contenu du mail est vide" + Environment.NewLine;
                tempCheck = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxServeurSMTP.Text))
            {
                message = message + "- L'adresse du serveur SMTP n'est pas indiqué" + Environment.NewLine;
                tempCheck = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxUtilisateurSMTP.Text))
            {
                message = message + "- L'utilisateur du serveur SMTP n'est pas indiqué" + Environment.NewLine;
                tempCheck = false;
            }


            if (string.IsNullOrWhiteSpace(textBoxPasswordSMTP.Text))
            {
                message = message + "- Le mot de passe du serveur SMTP n'est pas indiqué" + Environment.NewLine;
                tempCheck = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPortSMTP.Text))
            {
                message = message + "- Le port du serveur SMTP n'est pas indiqué" + Environment.NewLine;
                tempCheck = false;
            }

            if (tempCheck) return true;

            Debug.WriteLine("Erreur dans les champs");
            MessageBox.Show("Erreur lors de l'envoi du mail" + Environment.NewLine + message,
                "Envoi de mail");
            return false;
        }
    }
}