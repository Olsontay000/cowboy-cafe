using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;


namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        /// <summary>
        /// The items to display on the index page
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The filtered Categories
        /// </summary>
        [BindProperty]
        public string[] Categories { get; set; }

        /// <summary>
        /// The minimum Calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum Calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum Price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum Price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// Method to force side to medium for calories and price
        /// </summary>
        /// <param name="side">The side in its current size</param>
        /// <returns>String that is null, definitely Cowboy coding but can't find another way to call method without printing</returns>
        public string SideToMedium(Side side)
        {
            side.Size = Size.Medium;
            return null;
        }
        /// <summary>
        /// Method to force side to large for calories and price
        /// </summary>
        /// <param name="side">The side in its current size</param>
        /// <returns>String that is null, definitely Cowboy coding but can't find another way to call method without printing</returns>
        public string SideToLarge(Side side)
        {
            side.Size = Size.Large;
            return null;
        }
        /// <summary>
        /// Method to force drink to medium for calories and price
        /// </summary>
        /// <param name="side">The drink in its current size</param>
        /// <returns>String that is null, definitely Cowboy coding but can't find another way to call method without printing</returns>
        public string DrinkToMedium(Drink drink)
        {
            drink.Size = Size.Medium;
            return null;
        }
        /// <summary>
        /// Method to force drink to large for calories and price
        /// </summary>
        /// <param name="side">The drink in its current size</param>
        /// <returns>String that is null, definitely Cowboy coding but can't find another way to call method without printing</returns>
        public string DrinkToLarge(Drink drink)
        {
            drink.Size = Size.Large;
            return null;
        }

        public void OnGet()
        {
            Items = Menu.AllItems;
        }

        public void OnPost()
        {
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }

        //The method from the data class for entrees
        public static IEnumerable<IOrderItem> EntreeList { get { return Menu.Entrees(); } }
        //The method from the data class for sides
        public static IEnumerable<IOrderItem> SideList { get { return Menu.Sides(); } }
        //The method from the data class for drinks
        public static IEnumerable<IOrderItem> DrinkList { get { return Menu.Drinks(); } }
        //The method from the data class for all menu items
        public static IEnumerable<IOrderItem> CompleteList { get { return Menu.CompleteMenu(); } }
    }
}
