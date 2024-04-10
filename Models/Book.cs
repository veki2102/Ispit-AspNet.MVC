using System.ComponentModel;

namespace AspNet.MVC.Models
{
    public class Book
    {
        public Author Author { get; set; }

        public string Naslov { get; set; }

        [DisplayName("Broj stranica")]
        public int BrojStranica { get; set; }

        [DisplayName("Godina izdavanja")]
        public int GodinaIzdavanja { get; set; }


    }



}
