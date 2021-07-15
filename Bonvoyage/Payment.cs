using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Bonvoyage
{
    public record Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; }
        public decimal Discount { get; }
        public decimal FinalAmount { get; }
        public Card Card { get; set; }

        public Payment(int amount, int discount, long cardNumber, int cardCCV, string cardIssuer, BonContext context)
        {
            Amount = amount;
            Discount = discount;
            FinalAmount = amount - discount;

            //Check if the card already exists
            var CardQuery = context.Cards.SingleOrDefault(c => c.Number == cardNumber && c.CCV == cardCCV && c.Issuer == cardIssuer);

            //If the CardQuery has not returned null Card=CaredQuery else Card= new Card()
            Card= CardQuery?? new Card() {Number = cardNumber, Issuer = cardIssuer, CCV = cardCCV};

        }

        //Same logic but without a discount parameter, which is automatically set to 0

        public Payment(int amount,  long cardNumber, int cardCCV, string cardIssuer, BonContext context)
        {
            Amount = amount;
            Discount = 0;
            FinalAmount = amount;
            var CardQuery = context.Cards.SingleOrDefault(c => c.Number == cardNumber && c.CCV == cardCCV && c.Issuer == cardIssuer);
            Card = CardQuery ?? new Card() { Number = cardNumber, Issuer = cardIssuer, CCV = cardCCV };

        }

        //Same constructors but without card for cash payments

        public Payment(int amount, int discount)
        {
            Amount = amount;
            Discount = discount;
            FinalAmount = amount - discount;
        }

        public Payment(int amount)
        {
            Amount = amount;
            Discount = 0;
            FinalAmount = amount;
        }

        private Payment() //EF entities must always have an empty constructor
        {
        }


    }
}
