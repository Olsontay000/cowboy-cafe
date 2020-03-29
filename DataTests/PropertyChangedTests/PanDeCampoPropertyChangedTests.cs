using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        // Test 1: Pan De Campo should implement the INotifyPropertyChanged Interface
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var decampo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(decampo);
        }

        // Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangeForSize()
        {
            var decampo = new PanDeCampo();
            Assert.PropertyChanged(decampo, "Size", () =>
            {
                decampo.Size = Size.Large;
            });
        }

        // Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var decampo = new PanDeCampo();
            Assert.PropertyChanged(decampo, "Calories", () =>
            {
                decampo.Size = Size.Large;
            });
        }

        // Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var decampo = new PanDeCampo();
            Assert.PropertyChanged(decampo, "Price", () =>
            {
                decampo.Size = Size.Large;
            });
        }
    }
}
