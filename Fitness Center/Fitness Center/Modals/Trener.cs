using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness_Center.Modals
{
    public class Trener
    {
        public int ID { get; set; }
        public DateTime Datum_zaposlenja { get; set; }
        public DateTime Datum_prestanka_rada { get; set; }
        public string Strucna_sprema { get; set; }
        // public int Staz { get { return Datum_prestanka_rada.Year() - Datum_zaposlenja.Year(); }  }
        public int Staz { get; set; }

        [ForeignKey("OsobaID")]
        public Osoba Osoba { get; set; }
        public int OsobaID { get; set; }
    }
}
