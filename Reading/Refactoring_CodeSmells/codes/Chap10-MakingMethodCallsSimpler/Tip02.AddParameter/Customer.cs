namespace Tip02.AddParameter
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public Customer(string name, string address, string telephone)
        {
            Name = name;
            Address = address;
            Telephone = telephone;
        }
    }
}