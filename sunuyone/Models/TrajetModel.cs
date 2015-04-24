using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace sunuyone.Models
{
    public class TrajetModel
    {
        [DisplayName("Départ")]
        public string Depart { get; set; }
        [DisplayName("Arrivée")]
        public string Arrivee { get; set; }
        [DisplayName("Date")]
        public DateTime Date { get; set; }
        [DisplayName("Lieu de rencontre")]
        public string LieuRencontre { get; set; }
        [DisplayName("Heure de départ")]
        public string HeureDepart { get; set; }
        [DisplayName("Montant")]
        public int Montant { get; set; }
        [DisplayName("Commentaire")]
        public string Commentaire { get; set; }
    }
}