namespace Domain.Customers
{
    public class Customer
    {
        // StronglyTypeId Nuget Packages
        public CustomerId Id { get; private set; }

        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;

    }
}
