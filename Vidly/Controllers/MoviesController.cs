using Microsoft.AspNetCore.Mvc;
using Vidly.Models;  //refers to our 'Movie' model class

namespace Vidly.Controllers
{
    public class MoviesController : Controller //moviesController derived from the contoller class
    {
        //GET: /Movies/Random
        public ActionResult Random()  //we have an action called 'Random' that returns action result
        {
            /*create a new instance of movie.*/
            var movie = new Movie() { Name = "Shrek!"}; //in real life we will get this values from a web API or database

            return View(movie);  //return the View called Random. it should be in the View folder. so we go create the view
        }
    }
}
