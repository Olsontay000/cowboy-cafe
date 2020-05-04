using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

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

        public void OnGet()
        {
            Items = Menu.AllItems;
        }

        public void OnPost()
        {
            Items = Menu.AllItems;
            // Search item names for the searchterms
            if (SearchTerms != null)
            {
                //Items = from item in Items
                //        where item.ToString().Contains(SearchTerms, System.StringComparison.CurrentCultureIgnoreCase)
                //        select item;
                Items = Items.Where(item =>  item.ToString().Contains(SearchTerms, System.StringComparison.CurrentCultureIgnoreCase));
            }

            if(Categories != null && Categories.Length != 0)
            {
                Items = Items.Where(item =>
                (item is Entree entree && Categories.Contains("Entree")) ||
                (item is Side side && Categories.Contains("Side")) ||
                (item is Drink drink && Categories.Contains("Drink"))
                );
            }

            if (CaloriesMin != null || CaloriesMax != null)
            {
                if (CaloriesMin == null)
                {
                    Items = Items.Where(item => item.Calories <= CaloriesMax);
                }

                else if (CaloriesMax == null)
                {
                    Items = Items.Where(item => item.Calories >= CaloriesMin);
                }
                else
                {
                    Items = Items.Where(item => item.Calories >= CaloriesMin && item.Calories <= CaloriesMax);
                }
            }

            if(PriceMin != null || PriceMax != null)
            {
                if (PriceMin == null)
                {
                    Items = Items.Where(item => item.Price <= PriceMax);
                }

                else if (PriceMax == null)
                {
                    Items = Items.Where(item => item.Price >= PriceMin);
                }
                else
                {
                    Items = Items.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
                }
            }
            /*
             Items = Menu.Search(SearchTerms);
             Items = Menu.FilterByCategory(Items, Categories);
             Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
             Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
             */
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
