namespace Tip02.AddParameter
{
    public class Book
    {
        private List<Customer> _reservations = new List<Customer>();

        public void AddReservation(Customer customer)
        {
            _reservations.Add(customer);
        }
    }
}