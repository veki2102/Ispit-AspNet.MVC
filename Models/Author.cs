using System.ComponentModel;

namespace AspNet.MVC.Models
{
    public class Author
    {
        public int Id { get; set; }

        [DisplayName("Ime autora")]
        public string Ime { get; set; }

        [DisplayName("Prezime autora")]
        public string Prezime { get; set; }
        public int Godine { get; set; }


    }



}
