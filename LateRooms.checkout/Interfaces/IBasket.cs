using System;
namespace LateRooms.checkout.Interfaces
{
    public interface IBasket
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}
