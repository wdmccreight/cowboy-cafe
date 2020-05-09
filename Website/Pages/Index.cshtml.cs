using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using CCMenu = CowboyCafe.Data.Menu;



namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Holds the current menu that is shown in the html
        /// </summary>
        public IEnumerable<IOrderItem> Menu { get; protected set; }


        public string[] typeOfItems { get; set; }

        /// <summary>
        /// Search terms if the user wanted to search for something
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The minimum price to filter the items by
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; } = 0;

        /// <summary>
        /// The maximum price to filter the items by
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; } = 100;

        /// <summary>
        /// The minimum calorie to filter the items by
        /// </summary>
        [BindProperty]
        public int? CalorieMin { get; set; } = 0;

        /// <summary>
        /// The maximum calorie to filter the items by
        /// </summary>
        [BindProperty]
        public int? CalorieMax { get; set; } = 1000;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Hits this method when get request start flowing
        /// </summary>
        public void OnGet(int? CalorieMin, int? CalorieMax, double? PriceMin, double? PriceMax, string[]? typeOfItems)
        {
            this.CalorieMax = CalorieMax;
            this.CalorieMin = CalorieMin;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            SearchTerms = Request.Query["SearchTerms"];
            this.typeOfItems = Request.Query["typeOfItems"];


            if (this.typeOfItems.Length == 0)
            {
                typeOfItems = new string[]
                {
                    "Entrees",
                    "Sides",
                    "Drinks"
                };
            }

            //Menu = CCMenu.Search(CCMenu.CompleteMenu(), SearchTerms);
            //Menu = CCMenu.FilterByCalories(Menu, CalorieMin, CalorieMax);
            //Menu = CCMenu.FilterByCategory(Menu, typeOfItems.ToList());
            //Menu = CCMenu.FilterByPrice(Menu, PriceMin, PriceMax);

            Menu = CCMenu.CompleteMenu();

            


            if (SearchTerms != null)
            {

                Menu = (Menu.Where(item =>
                item.ToString() != null &&
                item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                ));
            }

            //Filter by Type
            if (typeOfItems != null && typeOfItems.Count() != 0)
            {
                //Show: Entrees, Sides, Drinks
                if (typeOfItems.Contains("Entrees") && typeOfItems.Contains("Sides") && typeOfItems.Contains("Drinks"))
                {

                }
                //Show: Entrees, Sides
                else if (typeOfItems.Contains("Entrees") && typeOfItems.Contains("Sides") && !typeOfItems.Contains("Drinks"))
                {
                    Menu = (Menu.Where(item =>
                    item is Entree ||
                    item is Side
                    ));
                }
                //Show: Entrees
                else if (typeOfItems.Contains("Entrees") && !typeOfItems.Contains("Sides") && !typeOfItems.Contains("Drinks"))
                {
                    Menu = (Menu.Where(item =>
                    item is Entree
                    ));

                }
                //Show: Sides
                else if (!typeOfItems.Contains("Entrees") && typeOfItems.Contains("Sides") && !typeOfItems.Contains("Drinks"))
                {
                    Menu = (Menu.Where(item =>
                    item is Side
                    ));
                }
                //Show: Drinks
                else if (!typeOfItems.Contains("Entrees") && !typeOfItems.Contains("Sides") && typeOfItems.Contains("Drinks"))
                {
                    Menu = (Menu.Where(item =>
                    item is Drink
                    ));

                }
                //Show: Sides, Drinks
                else if (!typeOfItems.Contains("Entrees") && typeOfItems.Contains("Sides") && typeOfItems.Contains("Drinks"))
                {
                    Menu = (Menu.Where(item =>
                    item is Side ||
                    item is Drink
                    ));
                }
                //Show: Entrees, Drinks
                else if (typeOfItems.Contains("Entrees") && !typeOfItems.Contains("Sides") && typeOfItems.Contains("Drinks"))
                {
                    Menu = (Menu.Where(item =>
                    item is Entree ||
                    item is Drink
                    ));
                }

            }


            //Price Filter
            if (PriceMin != null || PriceMax != null)
            {
                //Only Max
                if (PriceMin == null)
                {
                    Menu = Menu.Where(item => item.Price <= PriceMax);
                }
                //Only Min
                else if (PriceMax == null)
                {
                    Menu = Menu.Where(item => item.Price >= PriceMin);
                }
                else
                {
                    Menu = Menu.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
                }
            }


            //Calorie Filter
            if (CalorieMin != null || CalorieMax != null)
            {
                //Only Max
                if (CalorieMin == null)
                {
                    Menu = Menu.Where(item => item.Calories < CalorieMax );
                }
                //Only Min
                else if (CalorieMax == null)
                {
                    Menu = Menu.Where(item => item.Calories >= CalorieMax );
                }
                else
                {
                    Menu = Menu.Where(item => item.Calories >= CalorieMin && item.Calories <= CalorieMax);
                }
            }

        }
    }
}