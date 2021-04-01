using System;
using System.Linq;
using Xunit;

namespace DDDFirstLook.Tests
{
    public class ProductAggregateTests
    {
        [Fact]
        public void ChangeNameTests()
        {
            var product = new Product(1, "First");
            Assert.True(product.Name == "First");

            product.ChangeName("Second");
            Assert.True(product.Name == "Second");
        }

        [Fact]
        public void AddAvailabilityTests()
        {
            var product = new Product(1, "First");
            product.AddAvailability("black", 10);
            product.AddAvailability("black", 15);
            product.AddAvailability("blue", 10);
            product.AddAvailability("blue", 11);

            Assert.True(product.Availabilities.Count == 2);
            Assert.True(product.Total == 46);
            Assert.True(product.Availabilities.FirstOrDefault(x => x.Type == "black").Count == 25);
            Assert.True(product.Availabilities.FirstOrDefault(x => x.Type == "blue").Count == 21);

            product.AddAvailability("red", 5);
            Assert.True(product.Availabilities.Count == 3);
            Assert.True(product.Total == 51);

            Assert.True(product.Availabilities.FirstOrDefault(x => x.Type == "red").Count == 5);
        }
    }
}
