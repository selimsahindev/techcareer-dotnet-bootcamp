﻿namespace TechcareerDotnetBootcamp.Models
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}