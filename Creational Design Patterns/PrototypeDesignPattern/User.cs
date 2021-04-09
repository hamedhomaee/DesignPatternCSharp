namespace PrototypeDesignPattern
{
    public class User
    {
        public string Name { get; set; }
        public Address UserAddress { get; set; }

        public User ShallowClone() {
            return (User)this.MemberwiseClone();
        }

        public User DeepClone() {
            User user = (User)this.MemberwiseClone();
            user.UserAddress = (Address)UserAddress.Clone();
            return user;
        }
    }
}