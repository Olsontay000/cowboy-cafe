using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public static class Menu
    {
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
            BakedBeans beans = new BakedBeans();
            completemenu.Add(beans);
            ChiliCheeseFries chilicheesefries = new ChiliCheeseFries();
            completemenu.Add(chilicheesefries);
            CornDodgers dodgers = new CornDodgers();
            completemenu.Add(dodgers);
            PanDeCampo campo = new PanDeCampo();
            completemenu.Add(campo);
            //Drinks copy and paste
            JerkedSoda soda = new JerkedSoda();
            completemenu.Add(soda);
            TexasTea tea = new TexasTea();
            completemenu.Add(tea);
            CowboyCoffee coffee = new CowboyCoffee();
            completemenu.Add(coffee);
            Water water = new Water();
            completemenu.Add(water);

            return completemenu;
        }
    }
}
