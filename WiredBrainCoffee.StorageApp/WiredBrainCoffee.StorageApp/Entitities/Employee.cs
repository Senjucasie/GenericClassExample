﻿namespace WiredBrainCoffee.StorageApp.Entitities
{
    public class Employee:EntityBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"Id : {Id} ,First Name : {FirstName}";
       
    }
}
