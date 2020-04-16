using CowboyCafe.Data;
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

        }
        //The method from the data class for entrees
        public static IEnumerable<IOrderItem> EntreeList { get { return Menu.Entrees(); } }
        //The method from the data class for entrees
        public static IEnumerable<IOrderItem> SideList { get { return Menu.Sides(); } }
        //The method from the data class for entrees
        public static IEnumerable<IOrderItem> DrinkList { get { return Menu.Drinks(); } }
    }
}
