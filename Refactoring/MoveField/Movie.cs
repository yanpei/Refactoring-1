﻿namespace Refactoring.MoveField
{
    public class Movie
    {
        public Movie(string title, double price)
        {
            Title = title;
            Price = price;
        }
        public string Title { get; }
        public double Price { get; }
    }
}
