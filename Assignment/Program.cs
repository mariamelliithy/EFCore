﻿using Assignment.Data.Context;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
        }
    }
}
