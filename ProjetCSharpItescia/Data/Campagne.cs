using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharpItescia.Data
{

    public class Campagne
    {
        [Column("C_Nom")]
        [Required]
        [MaxLength(20)]
        [DataType("Text")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string NomCampagne { get; set; }
        [Column("C_ListeEmail")]
        [Required]
        [DataType("Text")]
        public string ListeEmail { get; set; }


        public Campagne(string nomCampagne, string listeEmail)
        {
            NomCampagne = nomCampagne;
            ListeEmail = listeEmail;
        }

        public Campagne(string nomCampagne)
        {
            NomCampagne = nomCampagne;
        }
            

        public Campagne() : this("Undefined") { }





    }
}
