﻿namespace WiredBrainCoffee.StorageApp.Entitities
{
    class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public override string ToString() => $"Id : {Id} ,First Name : {FirstName}";
       
    }
}