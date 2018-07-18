using System;

namespace CleanCode.NestedConditionals
{
    public class Customer
    {
        public int LoyaltyPoints { get; set; }
    }

    public enum CustomerLevel
    {
        Gold = 100,
    }

    public class Reservation
    {
        public Reservation(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        public DateTime From { get; set; }
        public Customer Customer { get; set; }
        public bool IsCanceled { get; set; }

        public void Cancel()
        {
            bool isGoldLevel = CheckCustomerLevel(Customer.LoyaltyPoints);
            if (isGoldLevel) ValidateCancelation(24);
                    
            ValidateCancelation(48);

            IsCanceled = true;
        }

        private bool CheckCustomerLevel(int loyaltyPoints)
        {
            return (int)CustomerLevel.Gold < loyaltyPoints;
        }
    
        private void ValidateCancelation(int hoursBeforeEvent)
        {
            if (DateTime.Now > From || (From - DateTime.Now).TotalHours < hoursBeforeEvent)
                throw new InvalidOperationException("It's too late to cancel.");
        }

   
        
    }
}
