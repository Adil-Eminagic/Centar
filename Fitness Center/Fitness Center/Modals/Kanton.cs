using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness_Center.Modals
{
    public class Kanton
    {
        public int ID { get; set; }
        public string Naziv { get; set; }

        [ForeignKey("DrzavaID")]
        public Drzava Drzava { get; set; }
        public int DrzavaID { get; set; }

    }
}
