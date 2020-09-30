using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ProjetCSharpItescia.NEf;

namespace ProjetCSharpItescia.Utils
{
    static class Util
    {
        /// <summary>
        /// Création de la table "campagnes" si la table n'existe pas
        /// </summary>
        public static void CreateTable()
        {
            var initializer = new CreateDatabaseIfNotExists<ContextEf>();
            initializer.InitializeDatabase(new ContextEf());
        }

        /// <summary>
        /// Pour vérifier si une adresse mail est au bon format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        internal static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
