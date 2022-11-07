using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness_Center.Modals
{
    public class Korisnik
    {
        public int ID { get; set; }
        public float Visina { get; set; }
        public float Tezina { get; set; }
        public DateTime Daatum_polasaka { get; set; }

        [ForeignKey("OsobaID")]
        public Osoba Osoba { get; set; }
        public int OsobaID { get; set; }

    }
}
