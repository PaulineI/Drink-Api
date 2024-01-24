using drink_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace drink_api.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DrinkController : ControllerBase
    {
        public static List<Drinks> DifferentDrinks { get; set; } = new List<Drinks>()
        {
            new Drinks
            {
                Id = 1,
                Name= "Classic Martini",
                Ingredients= new List <string> () { "2 1/2 oz Gin or Vodka", "1/2 oz Dry Vermouth", "Lemon twist or olive for garnish" },
                Instructions = "Stir the gin or vodka and vermouth with ice, then strain into a chilled martini glass. Garnish with a lemon twist or olive."
                },
            new Drinks()
            {
                Id = 2,
                Name = "Margarita",
                Ingredients= new List <string> () { "2 oz Tequila", "1 oz Triple sec", "1 oz Lime juice", "Salt for rimming (optional)"},
                Instructions = "Rim the glass with salt (if desired). Shake the tequila, triple sec, and lime juice with ice. Strain into the glass over ice."
            },
            new Drinks()
            {
                Id = 3,
                Name = "Mojito",
                Ingredients = new List <string> () { "2 oz White rum", "1 oz Lime juice", "2 tsp Sugar", "Fresh mint leaves", "Soda water" },
                Instructions= "Muddle mint leaves and sugar in a glass. Add lime juice and rum, stir. Fill the glass with ice and top with soda water."
            },

            new Drinks()
            {
                 Id = 4,
                 Name = "Pina Colada",
                 Ingredients = new List <string> () { "2 oz White rum", "3 oz Pineapple juice", "1 oz Coconut cream", "Pineapple slice for garnish" },
                Instructions = "Blend all ingredients with ice until smooth. Pour into a chilled glass and garnish with a pineapple slice."
            },
            new Drinks()
            {
                Id = 5,
                Name = "Negroni",
                Ingredients = new List <string> () {"1 oz Gin", "1 oz Campari", "1 oz Sweet Vermouth", "Orange twist for garnish" },
                Instructions= "Stir all ingredients with ice, then strain into a rocks glass over ice. Garnish with an orange twist."

            }
        };

        [HttpGet]
        public List<Drinks> Get()
        {
            return DifferentDrinks;
        }

        [HttpGet("{id}")]
        public ActionResult<Drinks?> Get(int id)
        {
            Drinks? DrinkToReturn = DifferentDrinks.FirstOrDefault(x => x.Id == id);
            if (DrinkToReturn != null)
            {
                return Ok(DrinkToReturn);
            }

            return NotFound("The drink does not exist in this menu!");
        }

        [HttpPost]
        public ActionResult Post(Drinks drink)
        {
            DifferentDrinks.Add(drink);
            return Ok();
        }


    }
}
