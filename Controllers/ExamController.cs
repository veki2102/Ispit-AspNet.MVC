using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {

            Author o1 = new Author()
            {
                Id = 1,
                Ime = "August",
                Prezime = "Šenoa",
                Godine = 55

            };



            Author o2 = new Author()
            {
                Id = 2,
                Ime = "Vjenceslav",
                Prezime = "Novak",
                Godine = 65

            };




            Author o3 = new Author()
            {
                Id = 3,
                Ime = "Tin",
                Prezime = "Ujević",
                Godine = 55

            };



            List<Book> knjige = new List<Book>()
            {
                new Book() {Author=o1, Naslov="Prosjak Luka",BrojStranica=120,GodinaIzdavanja=1985 },
                new Book() {Author=o1, Naslov="Barun Ivica",BrojStranica=450,GodinaIzdavanja=1987 },
                new Book() {Author=o2, Naslov="Posljednji Stipančići",BrojStranica=555,GodinaIzdavanja=1990 },
                new Book() {Author=o3, Naslov="Auto na Korzu",BrojStranica=785,GodinaIzdavanja=1997 },
                new Book() {Author=o1, Naslov="Zlatarovo zlato",BrojStranica=325,GodinaIzdavanja=1850 }
            };



            return View(knjige);


        }



    }
}
