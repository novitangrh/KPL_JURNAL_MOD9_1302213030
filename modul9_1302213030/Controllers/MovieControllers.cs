using Microsoft.AspNetCore.Mvc;

namespace modul9_1302213030.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieControllers : ControllerBase
    {
        public static List<Movie> ListMovie = new List<Movie> {
            new Movie("The Hobbit 1", "Peter Jackson", new List<string>{"Martin Freeman", "Ian McKellen", "Richard Armitage"},
                "Bilbo Baggins terhanyut dalam sebuah pencarian untuk merebut kembali Kerajaan Dwarf yang hilang dari Erebor " +
                "dari naga yang mengerikan bernama Smaug."),
            new Movie("The Hobbit 2", "Peter Jackson", new List<string>{"Martin Freeman", "Ian McKellen", "Richard Armitage"},
                "Para kurcaci, bersama dengan Bilbo Baggins dan Gandalf yang Kelabu, melanjutkan pencarian mereka untuk " +
                "merebut kembali Erebor, tanah air mereka, dari Smaug."),
            new Movie("The Hobbit 3", "Peter Jackson", new List<string>{"Martin Freeman", "Ian McKellen", "Richard Armitage"},
                "Bilbo dan kawan-kawannya terpaksa terlibat dalam perang melawan sekelompok penyerang dan menjaga Gunung " +
                "Kesepian agar tidak jatuh ke tangan kegelapan yang semakin menguat."),
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return ListMovie;
        }

        [HttpGet("{id}")]

        public Movie Get(int id)
        {
            return ListMovie[id];
        }

        [HttpPost]

        public void Post(Movie movie)
        {
            ListMovie.Add(movie);
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            ListMovie.RemoveAt(id);
        }
    }
}
