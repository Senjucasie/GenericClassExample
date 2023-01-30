namespace WiredBrainCoffee.StorageApp.Entitities
{
    class Organisation
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public override string ToString() => $"Id : {Id} ,First Name : {Name}";

    }
}
