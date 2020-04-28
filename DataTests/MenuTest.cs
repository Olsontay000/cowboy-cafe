using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.Linq;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class MenuTest
    {
        //Entrees should contain Angry Chicken, Cowpoke Chili, Trail Burger, Rustlers Ribs, Pecos Pulled Pork, Dakota Double Burger, Texas Triple Burger
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        public void EntreesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        //Entrees should only contain 7 items
        [Fact]
        public void EntreesShouldHaveOnlySevenItems()
        {
            Assert.Equal(7, Menu.Entrees().Count());
        }

        //Sides should contain Chili Cheese Fries, Baked Beans, Corn Dodgers, and Pan De Campo
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        public void SidesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        //Sides should only contain 4 items
        [Fact]
        public void SidesShouldHaveOnlyFourItems()
        {
            Assert.Equal(4, Menu.Sides().Count());
        }

        //Drinks should contain Jerked Soda, Texas tea, Cowboy Coffee, Water
        [Theory]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(Water))]
        public void DrinksShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        //Drinks should only contain 4 items
        [Fact]
        public void DrinksShouldHaveOnlyFourItems()
        {
            Assert.Equal(4, Menu.Drinks().Count());
        }

        //Drinks should contain Jerked Soda, Texas tea, Cowboy Coffee, Water
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(JerkedSoda))] 
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(Water))]
        public void AllItemsShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.AllItems)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //All Items should contain 31 items
        [Fact]
        public void AllItemsShouldHaveOnlyThirtyOneItems()
        {
            Assert.Equal(31, Menu.AllItems.Count());
        }
        //All items should have 4 medium sides
        [Fact]
        public void AllItemsShouldHaveFourMediumSides()
        {
            var mediumsides = new List<Side>();
            foreach (IOrderItem item in Menu.AllItems)
            {
                if (item is Side side)
                {
                    if (side.Size == Size.Medium)
                    {
                        mediumsides.Add(side);
                    }
                }
            }
            Assert.Equal(4, mediumsides.Count());
        }
        //All items should have 4 large sides
        [Fact]
        public void AllItemsShouldHaveFourLargeSides()
        {
            var largesides = new List<Side>();
            foreach (IOrderItem item in Menu.AllItems)
            {
                if (item is Side side)
                {
                    if (side.Size == Size.Large)
                    {
                        largesides.Add(side);
                    }
                }
            }
            Assert.Equal(4, largesides.Count());
        }
        //All items should have 4 medium drinks
        [Fact]
        public void AllItemsShouldHaveFourMediumDrinks()
        {
            var mediumdrinks = new List<Drink>();
            foreach (IOrderItem item in Menu.AllItems)
            {
                if (item is Drink drink)
                {
                    if (drink.Size == Size.Medium)
                    {
                        mediumdrinks.Add(drink);
                    }
                }
            }
            Assert.Equal(4, mediumdrinks.Count());
        }
        //All items should have 4 large drinks
        [Fact]
        public void AllItemsShouldHaveFourLargeDrinks()
        {
            var largedrinks = new List<Drink>();
            foreach (IOrderItem item in Menu.AllItems)
            {
                if (item is Drink drink)
                {
                    if (drink.Size == Size.Large)
                    {
                        largedrinks.Add(drink);
                    }
                }
            }
            Assert.Equal(4, largedrinks.Count());
        }
    }
}
