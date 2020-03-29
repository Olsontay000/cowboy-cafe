using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        // Test 1: Peco's Pulled Pork should implement the INotifyPropertyChanged Interface
        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var pulledpork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pulledpork);
        }

        // Test 2: Changing the "Bread" property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangeForBread()
        {
            var pulledpork = new PecosPulledPork();
            Assert.PropertyChanged(pulledpork, "Bread", () =>
            {
                pulledpork.Bread = false;
            });
        }

        // Test 3: Changing the "Bread" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pulledpork = new PecosPulledPork();
            Assert.PropertyChanged(pulledpork, "SpecialInstructions", () =>
            {
                pulledpork.Bread = false;
            });
        }

        // Test 4: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var pulledpork = new PecosPulledPork();
            Assert.PropertyChanged(pulledpork, "Pickle", () =>
            {
                pulledpork.Pickle = false;
            });
        }

        // Test 5: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pulledpork = new PecosPulledPork();
            Assert.PropertyChanged(pulledpork, "SpecialInstructions", () =>
            {
                pulledpork.Pickle = false;
            });
        }
    }
}
