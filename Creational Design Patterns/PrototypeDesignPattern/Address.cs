namespace PrototypeDesignPattern
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        public Address Clone() {
            return (Address)this.MemberwiseClone();
        }
    }
}