using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.Linq;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class SearchTest
    {
        //Searches the word "Word" or null and see if the list changes or doesn't
        [Theory]
        [InlineData("Word")]
        [InlineData(null)]
        public void SearchMethodShouldSearchList(string searchterm)
        {
            List<IOrderItem> searchresults = Menu.Search(searchterm) as List<IOrderItem>;
            if (searchterm != null)
            {
                bool DNE = searchresults.Count() == Menu.AllItems.Count();
                Assert.False(DNE);
            }
            else
            {
                bool equals = searchresults.Count() == Menu.AllItems.Count();
                Assert.True(equals);
            }
           
        }
        //Selects a button and checks the count or doesn't select a button and checks the count
        [Theory]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
        [InlineData(null)]
        public void SearchByCategorySearchesList(string categoryselection)
        {
            List<string> stringlist = new List<string>() { categoryselection };
            List<IOrderItem> searchresults = new List<IOrderItem>();
            if(categoryselection != null)
            {
                searchresults = Menu.FilterByCategory(Menu.AllItems, stringlist) as List<IOrderItem>;
            }
            else
            {
                searchresults = Menu.FilterByCategory(Menu.AllItems, null) as List<IOrderItem>;
            }

            if(categoryselection != null)
            {
                bool DNE = searchresults.Count() == Menu.AllItems.Count();
                Assert.False(DNE);
            }
            else
            {
                bool equals = searchresults.Count() == Menu.AllItems.Count();
                Assert.True(equals);
            }

        }
        //Sets arbitrary values for either min/max or both and checks if the count changes
        [Theory]
        [InlineData(1, 2)]
        [InlineData(null, 50)]
        [InlineData(100, null)]
        [InlineData(null, null)]
        public void SearchByCaloriesSearchesList(int? min, int? max)
        {
            List<IOrderItem> searchresults = new List<IOrderItem>();
            searchresults = Menu.FilterByCalories(Menu.AllItems, min, max) as List<IOrderItem>;

            if (min != null || max != null)
            {
                bool DNE = searchresults.Count() == Menu.AllItems.Count();
                Assert.False(DNE);
            }
            else
            {
                bool equals = searchresults.Count() == Menu.AllItems.Count();
                Assert.True(equals);
            }
        }
        //Sets arbitrary values for either min/max or both and checks if the count changes
        [Theory]
        [InlineData(0.1, 2.1)]
        [InlineData(null, 5.02)]
        [InlineData(6.05, null)]
        [InlineData(null, null)]
        public void SearchByPriceSearchesList(double? min, double? max)
        {
            List<IOrderItem> searchresults = new List<IOrderItem>();
            searchresults = Menu.FilterByPrice(Menu.AllItems, min, max) as List<IOrderItem>;

            if (min != null || max != null)
            {
                bool DNE = searchresults.Count() == Menu.AllItems.Count();
                Assert.False(DNE);
            }
            else
            {
                bool equals = searchresults.Count() == Menu.AllItems.Count();
                Assert.True(equals);
            }
        }

    }
}
