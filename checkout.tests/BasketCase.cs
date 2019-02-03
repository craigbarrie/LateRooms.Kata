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


        [Fact]
        public void SingleAInBasket() {

            var b = new Basket();
            b.Scan("A");

            Assert.Equal(50, b.Items[0].RowTotal);
        }

        [Fact]
        public void TwoAInBasket()
        {

            var b = new Basket();
            b.Scan("A");
            b.Scan("A");

            Assert.Equal(100, b.Items[0].RowTotal);
        }

        [Fact]
        public void ThreeAInBasket()
        {

            var b = new Basket();
            b.Scan("A");
            b.Scan("A");
            b.Scan("A");

            Assert.Equal(130, b.Items[0].RowTotal);
        }

        [Fact]
        public void FourAInBasket()
        {
            //this should be one lot of 3 at the special price
            //and a single one at the regular price
            //eg, 130 + 50

            var b = new Basket();
            b.Scan("A");
            b.Scan("A");
            b.Scan("A");
            b.Scan("A");

            Assert.Equal(180, b.Items[0].RowTotal);
        }

        [Fact]
        public void SixBInBasket()
        {
            //this should be be 3 lots of 2 at the special price  
            //eg, 45 * 3 = 135

            var b = new Basket();
            b.Scan("B");
            b.Scan("B");
            b.Scan("B");
            b.Scan("B");
            b.Scan("B");
            b.Scan("B");
            Assert.Equal(135, b.Items[0].RowTotal);
        }

        [Fact]
        public void SevenBInBasket()
        {
            //this should be be 3 lots of 2 at the special price  
            //ad one at the regular price
            //eg, 45 * 3 = 135
            //    30 * 1 = 30 
            //total 
            var b = new Basket();
            for (var i = 0; i < 7; i++) {
                b.Scan("B");
            }

            Assert.Equal(165, b.Items[0].RowTotal);
        }


        [Fact]
        public void ItemWithNoSpecialPrice() {
            var b = new Basket();
            b.Scan("C");
            b.Scan("C");
            Assert.Equal(40, b.Items[0].RowTotal);
        }




    }
}
