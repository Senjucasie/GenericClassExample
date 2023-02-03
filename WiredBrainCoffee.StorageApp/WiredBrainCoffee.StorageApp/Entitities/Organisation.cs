namespace WiredBrainCoffee.StorageApp.Entitities
{
    public class Organisation: EntityBase
    {
        public string? Name { get; set; }

        public override string ToString() => $"Id : {Id} ,First Name : {Name}";

    }
}
