using System;
using System.Collections.Generic;
using System.Linq;

namespace LateRooms.checkout.Models
{
    public class Basket
    {
        public List<BasketItem> Items{get;set;}

        Basket() {
            InitBasket();
        }

        void InitBasket() {
            Items = new List<BasketItem>();
        }

        public void Scan(string item) {
            AddItemToBasket(item);
        }

        public int GetTotalPrice() {

            //TODO:
            throw new NotImplementedException();
        
        }


        void AddItemToBasket(string sku) {
            var exists = Items.FirstOrDefault(i => i.SKU == sku);

            if (exists != null) {
                exists.Quantity += 1;
            }
            else {
                Items.Add(new BasketItem { SKU = sku, Quantity = 1 });
            }

        }


    }
}
