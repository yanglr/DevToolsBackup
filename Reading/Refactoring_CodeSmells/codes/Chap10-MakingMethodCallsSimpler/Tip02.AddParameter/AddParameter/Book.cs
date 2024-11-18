namespace Tip02.AddParameter.AddParameter
{
    public class Book
    {
        private Dictionary<Customer, bool> _reservationDict = new Dictionary<Customer, bool>();

        public void AddReservation(Customer customer, bool isPriority)
        {
            AddReservationWithPriority(customer, isPriority);
        }

        public void AddReservationWithPriority(Customer customer, bool isPriority)
        {
            _reservationDict.Add(customer, isPriority);
        }
    }
}