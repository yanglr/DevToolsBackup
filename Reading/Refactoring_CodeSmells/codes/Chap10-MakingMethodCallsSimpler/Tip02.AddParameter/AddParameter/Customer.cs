namespace Tip02.AddParameter.AddParameter
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

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Customer other = obj as Customer;
            return Equals(other);
        }

        private bool Equals(Customer other)
            => Name == other.Name && Address == other.Address && Telephone == other.Telephone;

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Name?.GetHashCode() ?? 0;
                hashCode = (hashCode * 397) ^ (Address?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Telephone?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}