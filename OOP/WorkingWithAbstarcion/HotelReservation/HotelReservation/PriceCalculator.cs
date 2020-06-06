using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class PriceCalculator
    {
        public double GetToTalPrice(double pricePerDay, int numberOfDays, Season inputSeason, DiscountType discount)
        {
            int multiplier = (int)inputSeason;
            double priceBeforeDiscount = pricePerDay * numberOfDays * multiplier;

            double discountCalculate = (double)discount / 100;
            double amountDiscount = priceBeforeDiscount * discountCalculate;

            double totalPrice = priceBeforeDiscount - amountDiscount;

            return totalPrice;
        }
    }
}
