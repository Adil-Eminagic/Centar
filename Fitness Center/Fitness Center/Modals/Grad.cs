using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness_Center.Modals
{
    public class Grad
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Postanski_broj { get; set; }
        [ForeignKey("DrzavaID")]
        public Drzava Drzava { get; set; }
        public int DrzavaID { get; set; }
        [ForeignKey("KantonID")]
        public Kanton Kanton { get; set; }
        public int KantonID { get; set; }
    }
}
