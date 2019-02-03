using System;
using Xunit;
using LateRooms.checkout.Data;
using LateRooms.checkout.Models;

namespace checkout.tests
{
    public class BasketCase
    {
        [Fact]
        public void AddOneOfEachItem()
        {
            var b = new Basket();

            for (var i=0; i < StockCatalogue.Items.Count; i++) {
                b.Scan(StockCatalogue.Items[i].SKUCode);
            }

            Assert.Equal(b.Items.Count, StockCatalogue.Items.Count);
        }
    }
}
