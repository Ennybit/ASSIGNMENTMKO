using ASSIGNMENTMKO.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASSIGNMENTMKO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class apiController : ControllerBase
    {
        [HttpGet]
        [Route("/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public IActionResult Get(int burger, int drink, int side, int dessert)
        {
            var burgers = new List<Burger>
            {
                new Burger
                {
                    Id = 1,
                    Option = "Cheeseburger",
                    Calories = 461
                },
                new Burger
                {
                    Id = 2,
                    Option = "Fish burger",
                    Calories = 431
                },
                new Burger
                {
                    Id = 3,
                    Option = "Veggie burger",
                    Calories = 420
                },
                new Burger
                {
                    Id = 4,
                    Option = "no burger",
                    Calories = 0
                }
            };
            var drinks = new List<Drink>
            {
                new Drink
                {
                    Id = 1,
                    Option = "Soft Drink",
                    Calories = 130
                },
                 new Drink
                {
                    Id = 2,
                    Option = "Orange Juice",
                    Calories = 160
                },
               new Drink
                {
                    Id = 3,
                    Option = "Milk",
                    Calories = 118
                },
               new Drink
                {
                    Id = 4,
                    Option = "no drink",
                    Calories = 0
                }
            };
            var sideorders = new List<SideOrder>
            {
                new SideOrder
                {
                    Id = 1,
                    Option = "Fries",
                    Calories = 100
                },
                new SideOrder
                {
                    Id = 2,
                    Option = "Baked Potato",
                    Calories = 57
                },
                new SideOrder
                {
                    Id = 3,
                    Option = "Chef Salad",
                    Calories = 70
                },
               new SideOrder
                {
                    Id = 4,
                    Option = "no side order",
                    Calories = 0
                }
            };
            var desserts = new List<Dessert>
            {
                new Dessert
                {
                    Id = 1,
                    Option = "Apple Pie",
                    Calories = 167
                },
                 new Dessert
                {
                    Id = 2,
                    Option = "Sundae",
                    Calories = 266
                },
                new Dessert
                {
                    Id = 3,
                    Option = "Fruit Cup",
                    Calories = 75
                },
                new Dessert
                {
                    Id = 4,
                    Option = "no dessert",
                    Calories = 0
                }
            };

            var burgerrequest = burgers.Find(burgers => burgers.Id == burger);
            
            var drinkrequest = drinks.Find(drinks => drinks.Id == drink);
            var siderequest = sideorders.Find(sideorders => sideorders.Id == side);
            var dessertrequest = desserts.Find(desserts => desserts.Id == dessert);

          
            var sum = burgerrequest.Calories + drinkrequest.Calories + siderequest.Calories + dessertrequest.Calories;

            return Ok("Your total calorie count is " + sum);
        }

        [HttpGet]
        [Route("J2/DiceGame/{m}/{n}")]
        public IActionResult Get(int m, int n)
        {
            int count = 0;
            int i, j;
            for(i = m; i >= 1; i--)
            {
                for(j = n; j >= 1; j--)
                {
                    int sum = i + j;

                    if(sum.Equals(10))
                    {
                        count++;
                    }
                 
                }
            }

            return Ok("There are " + count + " total ways to get the sum 10");
            
        }
    }
}
