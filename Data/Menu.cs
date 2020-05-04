using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace CowboyCafe.Data
{
    public static class Menu
    {
        private static List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Gets all the items avaliable
        /// </summary>
        public static IEnumerable<IOrderItem> AllItems { get { return CompleteMenu(); } }

        /// <summary>
        /// Static class that creates a default object for each entree and returns a list of them
        /// </summary>
        /// <returns>The list of default entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            AngryChicken chicken = new AngryChicken();
            entrees.Add(chicken);
            CowpokeChili chili = new CowpokeChili();
            entrees.Add(chili);
            TrailBurger trailburger = new TrailBurger();
            entrees.Add(trailburger);
            RustlersRibs ribs = new RustlersRibs();
            entrees.Add(ribs);
            PecosPulledPork pulledpork = new PecosPulledPork();
            entrees.Add(pulledpork);
            DakotaDoubleBurger dakotaburger = new DakotaDoubleBurger();
            entrees.Add(dakotaburger);
            TexasTripleBurger texasburger = new TexasTripleBurger();
            entrees.Add(texasburger);
            return entrees;
        }
        /// <summary>
        /// Static class that creates a default object for each side and returns a list of them
        /// </summary>
        /// <returns>The list of default sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            BakedBeans beans = new BakedBeans();
            sides.Add(beans);
            ChiliCheeseFries chilicheesefries = new ChiliCheeseFries();
            sides.Add(chilicheesefries);
            CornDodgers dodgers = new CornDodgers();
            sides.Add(dodgers);
            PanDeCampo campo = new PanDeCampo();
            sides.Add(campo);

            

            return sides;
        }

        /// <summary>
        /// Static class that creates a default object for each drink and returns a list of them
        /// </summary>
        /// <returns>The list of default drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            JerkedSoda soda = new JerkedSoda();
            drinks.Add(soda);
            TexasTea tea = new TexasTea();
            drinks.Add(tea);
            CowboyCoffee coffee = new CowboyCoffee();
            drinks.Add(coffee);
            Water water = new Water();
            drinks.Add(water);
            return drinks;
        }
        /// <summary>
        /// Static class that creates a default object for each entree, side, and drink and returns a list of them
        /// </summary>
        /// <returns>The list of default entrees, sides, and drinks</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> completemenu = new List<IOrderItem>();
            //Entrees copy and paste, couldn't get "Concat" to work so this is brute force implemented
            AngryChicken chicken = new AngryChicken();
            completemenu.Add(chicken);
            CowpokeChili chili = new CowpokeChili();
            completemenu.Add(chili);
            TrailBurger trailburger = new TrailBurger();
            completemenu.Add(trailburger);
            RustlersRibs ribs = new RustlersRibs();
            completemenu.Add(ribs);
            PecosPulledPork pulledpork = new PecosPulledPork();
            completemenu.Add(pulledpork);
            DakotaDoubleBurger dakotaburger = new DakotaDoubleBurger();
            completemenu.Add(dakotaburger);
            TexasTripleBurger texasburger = new TexasTripleBurger();
            completemenu.Add(texasburger);
            //Sides copy and paste
            BakedBeans smallbeans = new BakedBeans();
            completemenu.Add(smallbeans);
            BakedBeans mediumbeans = new BakedBeans();
            mediumbeans.Size = Size.Medium;
            completemenu.Add(mediumbeans);
            BakedBeans largebeans = new BakedBeans();
            largebeans.Size = Size.Large;
            completemenu.Add(largebeans);
            ChiliCheeseFries smallchilicheesefries = new ChiliCheeseFries();
            completemenu.Add(smallchilicheesefries);
            ChiliCheeseFries mediumchilicheesefries = new ChiliCheeseFries();
            mediumchilicheesefries.Size = Size.Medium;
            completemenu.Add(mediumchilicheesefries);
            ChiliCheeseFries largechilicheesefries = new ChiliCheeseFries();
            largechilicheesefries.Size = Size.Large;
            completemenu.Add(largechilicheesefries);
            CornDodgers smalldodgers = new CornDodgers();
            completemenu.Add(smalldodgers);
            CornDodgers mediumdodgers = new CornDodgers();
            mediumdodgers.Size = Size.Medium;
            completemenu.Add(mediumdodgers);
            CornDodgers largedodgers = new CornDodgers();
            largedodgers.Size = Size.Large;
            completemenu.Add(largedodgers);
            PanDeCampo smallcampo = new PanDeCampo();
            completemenu.Add(smallcampo);
            PanDeCampo mediumcampo = new PanDeCampo();
            mediumcampo.Size = Size.Medium;
            completemenu.Add(mediumcampo);
            PanDeCampo largecampo = new PanDeCampo();
            largecampo.Size = Size.Large;
            completemenu.Add(largecampo);
            //Drinks copy and paste
            JerkedSoda smallsoda = new JerkedSoda();
            completemenu.Add(smallsoda);
            JerkedSoda mediumsoda = new JerkedSoda();
            mediumsoda.Size = Size.Medium;
            completemenu.Add(mediumsoda);
            JerkedSoda largesoda = new JerkedSoda();
            largesoda.Size = Size.Large;
            completemenu.Add(largesoda);
            TexasTea smalltea = new TexasTea();
            completemenu.Add(smalltea);
            TexasTea mediumtea = new TexasTea();
            mediumtea.Size = Size.Medium;
            completemenu.Add(mediumtea);
            TexasTea largetea = new TexasTea();
            largetea.Size = Size.Large;
            completemenu.Add(largetea);
            CowboyCoffee smallcoffee = new CowboyCoffee();
            completemenu.Add(smallcoffee);
            CowboyCoffee mediumcoffee = new CowboyCoffee();
            mediumcoffee.Size = Size.Medium;
            completemenu.Add(mediumcoffee);
            CowboyCoffee largecoffee = new CowboyCoffee();
            largecoffee.Size = Size.Large;
            completemenu.Add(largecoffee);
            Water smallwater = new Water();
            completemenu.Add(smallwater);
            Water mediumwater = new Water();
            mediumwater.Size = Size.Medium;
            completemenu.Add(mediumwater);
            Water largewater = new Water();
            largewater.Size = Size.Large;
            completemenu.Add(largewater);

            return completemenu;
        }

        /// <summary>
        /// Searches the database for matching items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of items</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {

            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return AllItems;

            // return each movie in the database containing the terms substring
            foreach (IOrderItem item in AllItems)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }
        /// <summary>
        /// Filters by the the checkbox selected categories
        /// </summary>
        /// <param name="items">The list of menu items</param>
        /// <param name="selections">The selected categories</param>
        /// <returns>The updated list of menu items matching it</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> selections)
        {
            if (selections == null || selections.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if((item is Entree entree))
                {
                    if(selections.Contains("Entree"))
                    {
                        results.Add(entree);
                        
                    }
                }


                if ((item is Side side))
                {
                    if (selections.Contains("Side"))
                    {
                        results.Add(side);
                    }
                }


                if ((item is Drink drink))
                {
                    if (selections.Contains("Drink"))
                    {
                        results.Add(drink);
                    }
                }

            }

            return results;
        }

        /// <summary>
        /// Filters the list of menu items between the min and max calories
        /// </summary>
        /// <param name="items">The passed list of menu items</param>
        /// <param name="min">The user entered minimum calories</param>
        /// <param name="max">The user entered maximum calories</param>
        /// <returns>The updated list of menu items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
            }

            foreach(IOrderItem item in items)
            {
                if(item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the list of menu items between the min and max price
        /// </summary>
        /// <param name="items">The passed list of menu items</param>
        /// <param name="min">The user entered minimum price</param>
        /// <param name="max">The user entered maximum price</param>
        /// <returns>The updated list of menu items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
            }

            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
